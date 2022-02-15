using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void sendEmail(string to, string subject, string body)
        {
            MailAddress fromMail = new MailAddress(ConfigurationManager.AppSettings["sendEmail"], ConfigurationManager.AppSettings["senderDisplay"]);

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = fromMail;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Port = 25;
            client.Host = "127.0.0.1";
            client.UseDefaultCredentials = true;
            client.Send(mail);
        }
    }
}
