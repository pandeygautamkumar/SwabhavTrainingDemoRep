using AccountCounterApp.Model;
using System;

namespace AccountCounterApp
{
    internal class Program
    {
       // static string foo = "Hello";
        static void Main(string[] args)
        {
            //Console.WriteLine(foo);

            
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        { 
            Console.ForegroundColor= ConsoleColor.Blue;
            Account account1 = new Account(101, "A", 500);
            Console.WriteLine(Account.HeadCount());

            Account account2 = new Account(102, "B", 500);
            Console.WriteLine(Account.HeadCount());

            Account account3 = new Account(103, "C", 500);
            Console.WriteLine(Account.HeadCount());
        }

        private static void CaseStudy1()
        {
            Account account1 = new Account(101, "A", 500);
            Console.WriteLine(account1.InstanceCount);

            Account account2 = new Account(102, "B", 500);
            Console.WriteLine(account2.InstanceCount);

            Account account3 = new Account(103, "C", 500);
            Console.WriteLine(account3.InstanceCount);
        }

        private static void CaseStudy2()
        {
            Account account1 = new Account(101, "A", 500);
            Console.WriteLine(account1.InstanceCount);

            Account account2 = new Account(102, "B", 500);
            Console.WriteLine(account1.InstanceCount);

            Account account3 = new Account(103, "C", 500);
            Console.WriteLine(account1.InstanceCount);
        }
    }
}
