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
            sendEmail(new List<string> { to }, new List<string>(), subject, body);
        }


        public static void sendEmail(List<string> to, List<string> bcc, string subject, string body)
        {
            MailAddress fromMail = new MailAddress(ConfigurationManager.AppSettings["sendEmail"], ConfigurationManager.AppSettings["senderDisplay"]);

            MailMessage mail = new MailMessage();

            foreach (string email in to)
            {
                mail.To.Add(email); 
            }
            foreach (string email in bcc)
            {
                mail.To.Add(email);
            }


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
