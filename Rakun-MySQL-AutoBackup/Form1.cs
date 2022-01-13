using Newtonsoft.Json;
using RakunBackup.Model;
using RakunBackup.Service;
using RakunBackup.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RakunBackup
{
    public partial class Form1 : Form
    {
        private readonly FileService _fileService = new FileService();
        private readonly MysqlService _mysqlService = new MysqlService();
        private readonly FtpService _ftpService = new FtpService();
        private readonly EmailSendService _emailSendService = new EmailSendService();
        static Startup data = new Startup();
        public static DateTime nextBackupTime;

        public Form1()
        {
            InitializeComponent();
        }
        void UpdateLabels()
        {
            nextBackupTime = DateTime.Now.AddHours(data.restartTime);
            fatureClock.Invoke((MethodInvoker)delegate { fatureClock.Text = DateTime.Now.AddHours(data.restartTime).ToString("HH:mm:ss"); });
            lastBackup.Invoke((MethodInvoker)delegate { lastBackup.Text = DateTime.Now.ToString("HH:mm:ss"); });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var configControl = _fileService.ControlFile(Application.StartupPath, Constants.ConfigFile);
                var backupsControl = _fileService.ControlFile(Application.StartupPath + Constants.BackupFolder, null);

                if (!backupsControl)
                {
                    _fileService.CreateFile(Application.StartupPath + Constants.BackupFolder, null, null);
                }

                if (!configControl)
                {
                    _fileService.CreateFile(Application.StartupPath, Constants.ConfigFile, Constants.ConfigFileDefualtContext);
                    MessageBox.Show(Constants.CreateConfigFileError);
                    Application.Exit();
                }

                _fileService.ControlFile(Application.StartupPath + Constants.BackupFolder, null);
                var json = _fileService.ReadFile(Application.StartupPath + "/" + Constants.ConfigFile);
                data = JsonConvert.DeserializeObject<Startup>(json);
                backupTime.Text = data.restartTime + " saat";
                timer1.Start();
                UpdateLabels();
            }
            catch
            {
                MessageBox.Show(Constants.ConfigError);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManuelBackup.WorkerSupportsCancellation = true;
            ManuelBackup.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("HH:mm:ss");
            systemClock.Text = date;
            if (date == nextBackupTime.ToString("HH:mm:ss"))
            {
                Backup.WorkerSupportsCancellation = true;
                Backup.RunWorkerAsync();
                return;
            }
        }

        private void ManuelBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            var email = emailCheck.Checked;
            var ftp = ftpCheck.Checked;

            var filePath = _mysqlService.Backup(data.mysql);

            if (filePath == null)
            {
                MessageBox.Show(Constants.MysqlError);
                ManuelBackup.CancelAsync();
                return;
            }

            UpdateLabels();

            if (email && ftp)
            {
                _emailSendService.SendNotiEmail(data.email);
                _ftpService.UploadFile(data.ftp, filePath);
                MessageBox.Show(Constants.SuccessFtpEmailError);
                ManuelBackup.CancelAsync();
                return;
            }

            if (email)
            {
                _emailSendService.SendNotiEmail(data.email);
                MessageBox.Show(Constants.SuccessEmailError);
                ManuelBackup.CancelAsync();
                return;
            }

            if (ftp)
            {
                _ftpService.UploadFile(data.ftp, filePath);
                MessageBox.Show(Constants.SuccessFtpError);
                ManuelBackup.CancelAsync();
                return;
            }

            MessageBox.Show(Constants.SuccessError);
            ManuelBackup.CancelAsync();
            return;
        }

        private void Backup_DoWork(object sender, DoWorkEventArgs e)
        {
            var filePath = _mysqlService.Backup(data.mysql);

            if (filePath == null)
            {
                MessageBox.Show(Constants.MysqlError);
                Backup.CancelAsync();
                return;
            }

            UpdateLabels();

            _emailSendService.SendNotiEmail(data.email);
            _ftpService.UploadFile(data.ftp, filePath);
            return;
        }
    }
}
