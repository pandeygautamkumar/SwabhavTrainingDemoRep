namespace MiddleWareMVCApp.Services
{
    public class OutlookService : IEmailService
    {
        public OutlookService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OutLookService Created!!");
            Console.ResetColor();
        }
        public Task SendEmail(string from, string to, string details)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Sending Email via Outlook.!!");
                Console.WriteLine("From : {0} to : {1} Details : {2}", from, to, details);
            });
        }
    }
}
