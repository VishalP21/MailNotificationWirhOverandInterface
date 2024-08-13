using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNotificationWirhOverandInterface
{
    public class SMTPConfrig
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public bool EnableSsl { get; set; }

        public string FromEmail { get; set; }

        public string FromPassword { get; set; }


        public virtual void SetEmailConfiguration()
        {
            Host = "smtp.gmail.com";
            Port = 587;
            EnableSsl = true;
            FromPassword = "aoll ijcd ityg matl";
            FromEmail = "vishalp951295@gmail.com";

        }

    }
}
