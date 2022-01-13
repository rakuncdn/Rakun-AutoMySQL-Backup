using RakunBackup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RakunBackup.Service
{
    public class EmailSendService
    {
        public void SendNotiEmail(Email model)
        {
            try
            {
                model.body = model.body.Replace("{date}",DateTime.Now.ToString());
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(model.smtp);

                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.From = new MailAddress(model.senderemail);
                foreach (var item in model.email)
                {
                    mail.To.Add(item);
                }
                mail.Subject = model.subject;
                mail.Body = DateTime.Now.ToString("dd-MM-yyyy ") + "tarihinde " + "saat " + DateTime.Now.ToString("HH-mm") + " de" + model.body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(model.senderemail, model.password);
                SmtpServer.EnableSsl = false;
                SmtpServer.Send(mail);
            }
            catch
            {
                return;
            }
        }
    }
}
