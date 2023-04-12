using AxisBankSuscriber.Notifer;
using PublisherCoreLib.Model;

namespace AxisBankSuscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Gautam");
            acc1.Deposit(1000);
            acc1.AddSubscriber(new EmailNotifer());
            acc1.Withdraw(100);
            acc1.AddSubscriber(new SmsNotifier());
            acc1.Deposit(300);
        }
    }
}