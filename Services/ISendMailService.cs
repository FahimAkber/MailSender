using System;
using Models;


namespace Services
{
    public interface ISendMailService
    {
        string SendMail(MailData mail);
    }
}
