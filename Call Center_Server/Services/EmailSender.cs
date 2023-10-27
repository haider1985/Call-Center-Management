using Call_Center_Server.Common;

using Microsoft.AspNetCore.Identity.UI.Services;

using System.Net;
using System.Net.Mail;

namespace Call_Center_Server.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailMessage mailMessage = new MailMessage(StaticConstant.EmailService_EmailAddress, email, subject, htmlMessage)
            {
                IsBodyHtml = true
            };

            var client = new SmtpClient(StaticConstant.EmailService_SmtpClientInfo, StaticConstant.EmailService_SmtpClientPortNumber)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(StaticConstant.EmailService_EmailAddress, StaticConstant.EmailService_Password),
            };

            return client.SendMailAsync(mailMessage);
        }
    }
}
