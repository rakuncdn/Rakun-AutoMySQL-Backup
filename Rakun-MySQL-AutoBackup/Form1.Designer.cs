namespace RakunBackup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.emailCheck = new System.Windows.Forms.CheckBox();
            this.ftpCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.systemClock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fatureClock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backupTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastBackup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ManuelBackup = new System.ComponentModel.BackgroundWorker();
            this.Backup = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yedekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailCheck
            // 
            this.emailCheck.AutoSize = true;
            this.emailCheck.Location = new System.Drawing.Point(20, 30);
            this.emailCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailCheck.Name = "emailCheck";
            this.emailCheck.Size = new System.Drawing.Size(141, 20);
            this.emailCheck.TabIndex = 1;
            this.emailCheck.Text = "Email ile bilgilendir";
            this.emailCheck.UseVisualStyleBackColor = true;
            // 
            // ftpCheck
            // 
            this.ftpCheck.AutoSize = true;
            this.ftpCheck.Location = new System.Drawing.Point(20, 58);
            this.ftpCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ftpCheck.Name = "ftpCheck";
            this.ftpCheck.Size = new System.Drawing.Size(155, 20);
            this.ftpCheck.TabIndex = 2;
            this.ftpCheck.Text = "Uzak sunucuya yükle";
            this.ftpCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailCheck);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ftpCheck);
            this.groupBox1.Location = new System.Drawing.Point(355, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(219, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manuel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.systemClock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fatureClock);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.backupTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lastBackup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(331, 134);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgilendirme";
            // 
            // systemClock
            // 
            this.systemClock.AutoSize = true;
            this.systemClock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.systemClock.Location = new System.Drawing.Point(157, 101);
            this.systemClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.systemClock.Name = "systemClock";
            this.systemClock.Size = new System.Drawing.Size(0, 22);
            this.systemClock.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sistem Saati:";
            // 
            // fatureClock
            // 
            this.fatureClock.AutoSize = true;
            this.fatureClock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fatureClock.Location = new System.Drawing.Point(229, 78);
            this.fatureClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatureClock.Name = "fatureClock";
            this.fatureClock.Size = new System.Drawing.Size(0, 22);
            this.fatureClock.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gelecek Yedekleme:";
            // 
            // backupTime
            // 
            this.backupTime.AutoSize = true;
            this.backupTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backupTime.Location = new System.Drawing.Point(208, 52);
            this.backupTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backupTime.Name = "backupTime";
            this.backupTime.Size = new System.Drawing.Size(0, 22);
            this.backupTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yedekleme Aralığı:";
            // 
            // lastBackup
            // 
            this.lastBackup.AutoSize = true;
            this.lastBackup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastBackup.Location = new System.Drawing.Point(188, 27);
            this.lastBackup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastBackup.Name = "lastBackup";
            this.lastBackup.Size = new System.Drawing.Size(0, 22);
            this.lastBackup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Son Yedekleme:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManuelBackup
            // 
            this.ManuelBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ManuelBackup_DoWork);
            // 
            // Backup
            // 
            this.Backup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Backup_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 159);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "RakunBackup Otomatik MySQL Yedekleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox emailCheck;
        private System.Windows.Forms.CheckBox ftpCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label backupTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fatureClock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label systemClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker ManuelBackup;
        private System.ComponentModel.BackgroundWorker Backup;
    }
}

