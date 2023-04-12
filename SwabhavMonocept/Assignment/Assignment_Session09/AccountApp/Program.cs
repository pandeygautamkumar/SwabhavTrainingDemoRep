using AccountApp.Model;
using System;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            // CaseStudy3();
        }
       
        private static void CaseStudy3()
        {
            Account[] manyAccounts = new Account[4];
            manyAccounts[0] = new Account(1001, "Gautam Kumar Pandey", 1000);
            manyAccounts[1] = new Account(1002, "Sandeep Kumar Pandey", 1200.56);
            manyAccounts[2] = new Account(1003, "Ravi Kumar", 24242.67);
            manyAccounts[3] = new Account(1004, "Gautam Kumar Pandey", 1200);
            manyAccounts[1].Name = "Ram";
            Account[] longNamedAccHolders = FindAccountHolderWithLongNames(manyAccounts);
            foreach(Account account in longNamedAccHolders)
            {
                if(account.Name!=null)
                   PrintDetails(account);
            }
        }

        public static Account[] FindAccountHolderWithLongNames(Account[] manyAccounts)
        {
            int count = 0;
            for (int i = 0; i < manyAccounts.Length; i++)
            {
                if (manyAccounts[i].Name.Length >=10)
                {
                    count++;
                }
            }
            Account[] longNameAccount = new Account[count];
            int j= 0;
            for (int i = 0; i < manyAccounts.Length; i++)
            {
                if (manyAccounts[i].Name.Length >= 10)
                {
                    longNameAccount[j++] = manyAccounts[i];
                }
            }
            return longNameAccount;
        }
        private static void CaseStudy2()
        {
            Account[] manyAccounts = new Account[4];
            manyAccounts[0] = new Account(1001, "Gautam Kumar Pandey", 1000);
            manyAccounts[1] = new Account(1002, "Sandeep Kumar Pandey", 1200.56);
            manyAccounts[2] = new Account(1003, "Ravi Kumar", 24242.67);
            manyAccounts[3] = new Account(1004, "Gautam Kumar Pandey", 1200);
            manyAccounts[2].Withdraw(20000);
            Account rich = FindTheRichestAccountHolder(manyAccounts);
            PrintDetails(rich);
        }

        public static Account FindTheRichestAccountHolder(Account[] manyAccounts)
        {
            Account maxAmmountHolder = manyAccounts[0];
            for (int i = 1; i < manyAccounts.Length; i++)
            {
                if (manyAccounts[i].Balance >maxAmmountHolder.Balance)
                {
                    maxAmmountHolder = manyAccounts[i];
                }
            }
            return maxAmmountHolder;
        }

        private static void CaseStudy1()
        {
            Console.Write("Enter How Many Account Holder Will be Present : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Account[] manyAccounts = new Account[number];
            for (int i = 0; i < number; i++)
            {
                manyAccounts[i] = TakeUserInput();
            }
            foreach (Account account in manyAccounts)
            {
                PrintDetails(account);
            }
        }
        
        static Account TakeUserInput()
        {
            Console.Write("Enter Account Number : ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name Of Account Holder : ");
            string name = Console.ReadLine();
            Console.Write("Enter Initial Ammount : ");
            int balance = Convert.ToInt32(Console.ReadLine());
            Account account = new Account(accountNumber, name, balance);
            return account;
        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Number is : " + account.AccountNo);
            Console.WriteLine("Account Holder Name is : " + account.Name);
            Console.WriteLine("Amount Will be : " + account.Balance);
        }
    }
}
