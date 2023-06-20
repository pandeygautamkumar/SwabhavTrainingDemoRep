namespace MiddleWareMVCApp.Services
{
    public class GmailService:IEmailService
    {
        public GmailService()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GmailService Created!!");
            Console.ResetColor();
        }
        public Task SendEmail(string from, string to, string details)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Sending Email via Outlook.!!");
                Console.WriteLine("From : {0} to : {1} Details : {2}",from,to,details);
            });
        }
    }
}
