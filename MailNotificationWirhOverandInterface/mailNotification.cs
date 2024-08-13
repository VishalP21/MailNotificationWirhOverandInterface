using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MailNotificationWirhOverandInterface
{
    public class mailNotification : SMTPConfrig, INotification
    {

        public override void SetEmailConfiguration()
        {
            base.SetEmailConfiguration();
        }


        public bool SendNotification(string to, string title, string message1)
        {


            var smtp = new SmtpClient
            {
                Host = Host,
                Port = Port,
                EnableSsl = EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromEmail, FromPassword)
            };
            using (var message = new MailMessage(FromEmail, to)
            {
                Subject = title,
                Body = message1,
                IsBodyHtml = true,
            })
            {
                smtp.Send(message);
            }
            return true;
        }
    }
}
