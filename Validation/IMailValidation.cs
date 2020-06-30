using System;
using Models;

namespace Validation
{
    public interface IMailValidation
    {
        string MailValidate(MailData mail);
    }
}
