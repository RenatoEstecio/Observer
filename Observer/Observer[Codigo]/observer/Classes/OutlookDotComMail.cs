using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace observer.Classes
{
    public class OutlookDotComMail
    {
        string _sender;
        string _password;
        public OutlookDotComMail(string sender, string password)
        {
            _sender = sender;
            _password = password;
        }
        public OutlookDotComMail() {
            var login = File.ReadAllText("Email_Sender.txt").Split(';');
            _sender = login[0];
            _password = login[1];
        }

        public void SendMail(List<string> destinatarios, string subject, string message)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential(_sender, _password);
            client.EnableSsl = true;
            client.Credentials = credentials;

            try
            {
                var mail = new MailMessage();

                mail.From = new MailAddress(_sender);
                mail.Body = message;
                mail.Subject = subject;

                foreach (var e in destinatarios)
                    if(e!=null || e.Length>0)
                        mail.To.Add(e);
             
                client.Send(mail);
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
    }
}