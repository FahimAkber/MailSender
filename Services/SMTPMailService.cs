using System;
using System.Net.Mail;
using Models;

namespace Services
{
    public class SMTPMailService : ISendMailService
    {
        public String SendMail(MailData mail)
        {
            string recipient = mail.Recipient;
            string subject = mail.Subject;
            string content = mail.Content;

            MailMessage sendMail = new MailMessage();
            sendMail.To.Add(recipient);
            sendMail.From = new MailAddress("aversoftbd@gmail.com");
            sendMail.Subject = subject;
            sendMail.Body = content;
            sendMail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("aversoftbd@gmail.com", "aversoftbd@1997");
            smtp.Send(sendMail);
            
            return "Success";
        }
    }
}
