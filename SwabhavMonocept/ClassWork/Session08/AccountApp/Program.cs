using AccountApp.Model;
using System;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
           // CaseStudy2();
            //CaseStudy3();
           CaseStudy4();
        }

        private static void CaseStudy1()
        {
            Account accountA = new Account(1001, "Gautam");
            PrintDetails(accountA);
        }

        private static void CaseStudy2()
        {
            Console.WriteLine();
            Account accountB = new Account(1002, 1000, "Ravi");
            PrintDetails(accountB);
        }
        private static void CaseStudy3()
        {
            Account accountA = new Account(1001, "Gautam");
            accountA.Deposit(1000);
            PrintDetails(accountA);
        }
        private static void CaseStudy4()
        {
            Account accountA = new Account(1001, 1500,"Gautam");
            accountA.Withdraw(1001);
            PrintDetails(accountA);
        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Number is : " + account.AccountNo);
            Console.WriteLine("Balance Will be : " + account.Balance);
            Console.WriteLine("Name is : " + account.Name);
        }
    }
}
