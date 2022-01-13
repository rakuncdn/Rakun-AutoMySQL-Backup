using RakunBackup.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RakunBackup.Service
{
    public class FtpService
    {
        public void UploadFile(Ftp model, string filePath)
        {
            try
            {
                FileStream stream = File.OpenRead(filePath);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(model.path + Path.GetFileName(filePath));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(model.username, model.password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Close();

                /*WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(model.username, model.password);
                client.UploadFile(, filePath);*/
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
