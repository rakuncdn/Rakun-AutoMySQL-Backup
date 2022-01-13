using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakunBackup.Service
{
    public class FileService
    {
        public void CreateFile(string path, string filename, string context)
        {
            if (filename != null && context != null)
            {
                using (FileStream fs = File.Create(path+"\\"+filename))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(context);
                    fs.Write(info, 0, info.Length);
                    fs.Flush();
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }
        public bool ControlFile(string path, string filename)
        {
            if (filename != null)
            {
                if (File.Exists(path + "//" + filename)) return true;
                return false;
            }
            else
            {
                if (Directory.Exists(path)) return true;
                return false;
            }
            
        }
        public string ReadFile(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch
            {
                return null;
            }
        }
    }
}
