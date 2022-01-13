using MySql.Data.MySqlClient;
using RakunBackup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RakunBackup.Service
{
    class MysqlService
    {
        public string Backup(Mysql model)
        {
            var startupPath = Application.StartupPath;
            var constring = "server=" + model.server + ";user id=" + model.username + ";port=" + model.port + ";password=" + model.password + ";persistsecurityinfo=True;database=" + model.database + ";charset=utf8;";
            var file = startupPath + @"\backup\" + DateTime.Now.ToString("mm-dd-yyyy_") + DateTime.Now.ToString("HH-mm-ss") + ".sql";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
                return file;
            }
            catch
            {
                return null;
            }
        }
    }
}
