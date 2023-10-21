namespace Call_Center_Server.Services.IServices
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(string emailTo, string subjuct, string message);
    }
}
