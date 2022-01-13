using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakunBackup.Model
{
    public class Startup
    {
        public Mysql mysql { get; set; }
        public Ftp ftp { get; set; }
        public Email email { get; set; }
        public int restartTime { get; set; }
    }
    public class Mysql
    {
        public string name { get; set; }
        public string username { get; set; }
        public string port { get; set; }
        public string database { get; set; }
        public string server { get; set; }
        public string password { get; set; }
    }
    public class Email
    {
        public List<string> email { get; set; }
        public string smtp { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public string senderemail { get; set; }
        public string password { get; set; }
    }
    public class Ftp
    {
        public string username { get; set; }
        public string password { get; set; }
        public string path { get; set; }
    }

}
