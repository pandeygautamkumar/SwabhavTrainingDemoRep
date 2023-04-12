using System;
using AccountLibrary;

namespace AccountConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountA = new Account(1020302, "Gautam Kumar Pandey", 1000);
            PrintDetails(accountA,"Initial Ammount of Account A");
            accountA.Deposit(5000);
            PrintDetails(accountA, "After Deposit Account A");
            accountA.Withdraw(5000);
            PrintDetails(accountA, "After Withdraw Some Ammount from Account A");
            accountA.Withdraw(5000);
            PrintDetails(accountA, "Withdraw Some Ammount from Account A if No Sufficient Ammount Available");
        }
        private static void PrintDetails(Account account,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Account Number is : "+account.AccountNo);
            Console.WriteLine("Account Holder Name : "+ account.Name);
            Console.WriteLine("Ammount is : " + account.Balance);
            Console.WriteLine("----------------------------------------");
        }
    }
}
