using Call_Center_Server.Common;
using Call_Center_Server.Services.IServices;

using System.Net;
using System.Net.Mail;

namespace Call_Center_Server.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public Task SendEmailAsync(string emailTo, string subjuct, string message)
        {
            var client = new SmtpClient(StaticConstant.EmailService_SmtpClientInfo, StaticConstant.EmailService_SmtpClientPortNumber)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(StaticConstant.EmailService_EmailAddress, StaticConstant.EmailService_Password)
            };

            MailMessage mailMessage = new MailMessage(StaticConstant.EmailService_EmailAddress, emailTo, subjuct, message);
            mailMessage.IsBodyHtml = true;
            return client.SendMailAsync(mailMessage);
        }
    }
}
