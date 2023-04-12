
using PublisherCoreLib.Model;

namespace HDFCBankSuscriber.Notifer
{
    internal class WhatsappNotifer : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sending Whatsapp Notification");
            Console.WriteLine("Account Holder Name : " + account.Name);
            Console.WriteLine("Final Balance is : " + account.Balance);
        }
    }
}
