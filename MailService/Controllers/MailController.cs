using System;
using Microsoft.AspNetCore.Mvc;
using Services;
using Models;
using Validation;

namespace MailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private ISendMailService service;
        private IMailValidation validation;
        public MailController(ISendMailService service, IMailValidation validation){
            this.service = service;
            this.validation = validation;
        }
        [HttpPost]
        public string SendMail(MailData mail){
           string response =  validation.MailValidate(mail);
           
           if(response.Equals("valid")){
               response = service.SendMail(mail);
           }

           return response;
        }
    }
}
