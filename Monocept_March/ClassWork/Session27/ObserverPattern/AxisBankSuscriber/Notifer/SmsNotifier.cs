
using PublisherCoreLib.Model;

namespace AxisBankSuscriber.Notifer
{
    internal class SmsNotifier : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sending SMS Notification");
            Console.WriteLine("Account Holder Name : " + account.Name);
            Console.WriteLine("Final Balance is : " + account.Balance);
        }
    }
}
