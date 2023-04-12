
using PublisherCoreLib.Model;

namespace AxisBankSuscriber.Notifer
{
    internal class EmailNotifer : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sending Email Notification");
            Console.WriteLine("Account Holder Name : " + account.Name);
            Console.WriteLine("Final Balance is : " + account.Balance);
        }
    }
}
