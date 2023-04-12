using HDFCBankSuscriber.Notifer;
using PublisherCoreLib.Model;

namespace HDFCBankSuscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Anikant");
            acc1.Deposit(4000);
            acc1.AddSubscriber(new WhatsappNotifer());
            acc1.Withdraw(100);
        }
    }
}