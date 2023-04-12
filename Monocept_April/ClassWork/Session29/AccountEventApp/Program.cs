using AccountEventApp.Model;

namespace AccountEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Gautam");
            acc1.OnBalanceChanged += SendSms;
            acc1.OnBalanceChanged += SendEmail;

            acc1.Deposit(300);
        }
        private static void SendSms(Account acc)
        {
            Console.WriteLine("Sending SMS to : " + acc.Name);
            Console.WriteLine("Balance Changed to : " + acc.Balance);
        }
        private static void SendEmail(Account acc)
        {
            Console.WriteLine("Sending Email to : " + acc.Name);
            Console.WriteLine("Balance Changed to : " + acc.Balance);
        }
    }
}