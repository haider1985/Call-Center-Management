using Call_Center_Server.Services.IServices;

using System.Net;
using System.Net.Mail;

namespace Call_Center_Server.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public Task SendEmailAsync(string emailTo, string subjuct, string message)
        {
            var emailSenderAddress = "eng.haider85@outlook.com";
            var pw = "ZOha94&85";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(emailSenderAddress, pw)
            };

            MailMessage mailMessage = new MailMessage(emailSenderAddress, emailTo, subjuct, message);
            mailMessage.IsBodyHtml = true;
            return client.SendMailAsync(mailMessage);
        }
    }
}
