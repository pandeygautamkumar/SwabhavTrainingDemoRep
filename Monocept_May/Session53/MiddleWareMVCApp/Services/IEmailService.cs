namespace MiddleWareMVCApp.Services
{
    public interface IEmailService
    {
        Task SendEmail(string from, string to, string details);
    }
}
