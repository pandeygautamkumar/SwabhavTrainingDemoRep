using AccountPolymorphismApp.Model;
using System;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            Account acc3 = new SavingsAccount(102002, "Ravi", 10000);
            acc3.Deposit(50000);
            acc3.Withdraw(450);
            PrintDetails(acc3, "Account Class Object Casting");
        }

        private static void CaseStudy3()
        {
            CurrentAccount acc2 = new CurrentAccount(102002, "Ravi", 1000);
            PrintDetails(acc2, "acc1 Current Account");
            acc2.Withdraw(5000);
            PrintDetails(acc2, "acc1 Current Account after first Withdraw.");
            acc2.Withdraw(3000);
            PrintDetails(acc2, "acc1 Current Account after Second Withdraw.");
        }

        private static void CaseStudy2()
        {
            SavingsAccount acc1 = new SavingsAccount(10101, "Abc", 1000);
            PrintDetails(acc1, "acc1 Saving Account");
            acc1.Withdraw(1000);
            PrintDetails(acc1, "acc1 Saving Account After Withdraw.");
        }

        private static void CaseStudy1()
        {
            SavingsAccount acc1 = new SavingsAccount(10101, "Abc", 1000);
            PrintDetails(acc1, "acc1 Saving Account");

            CurrentAccount acc2 = new CurrentAccount(102002, "Ravi", 10000);
            PrintDetails(acc2, "acc1 Current Account");
        }

        static void PrintDetails(Account account,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Account Number is : {0} ",account.AccountNo);
            Console.WriteLine("Name is : {0}", account.Name);
            Console.WriteLine("Balance is :{0} " , account.Balance);
            Console.WriteLine("------------------------------------------------");
        }
    }
}
