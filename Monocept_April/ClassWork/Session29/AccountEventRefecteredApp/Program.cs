using AccountEventRefecteredApp.Model;

namespace AccountEventRefecteredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Gautam");
            acc1.OnBalanceChanged += (a) =>
            {
                Console.WriteLine("Sending SMS to : " + a.Name);
                Console.WriteLine("Balance Changed to : " + a.Balance);
            };
            acc1.OnBalanceChanged += (a) =>
            {
                Console.WriteLine("Sending Email to : " + a.Name);
                Console.WriteLine("Balance Changed to : " + a.Balance);
            };
            acc1.OnBalanceChanged += (a) =>
            {
                Console.WriteLine("Sending WhatsApp msg to : " + a.Name);
                Console.WriteLine("Balance Changed to : " + a.Balance);
            };

            acc1.Deposit(300);
        }
    }
}