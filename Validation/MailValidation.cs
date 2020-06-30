using System;
using Models;

namespace Validation
{
    public class MailValidation : IMailValidation
    {
        public string MailValidate(MailData mail)
        {
            string response = "valid";

            if(mail.Recipient.Equals("")){
                response = "Provide Recipient Address!";
            } else if(mail.Subject.Equals("")){
                response = "Provide Subject!";
            } else if(mail.Content.Equals("")){
                response = "Provide Content!";
            }

            return response;

        }
    }
}
