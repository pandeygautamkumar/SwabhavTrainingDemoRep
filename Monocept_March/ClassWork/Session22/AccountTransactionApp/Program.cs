using AccountTransactionApp.Model;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Account account1 = new Account(1011, "Vikrant");
            account1.Deposit(1000);
            account1.Withdraw(100);
            account1.Deposit(400);

            IEnumerator<Transaction> enumerator = account1.Transactions.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.WriteLine(account1.Balance);
        }

        private static void CaseStudy1()
        {
            Account account1 = new Account(1011, "Vikrant");
            account1.Deposit(1000);
            account1.Withdraw(200);
            account1.Deposit(1000);
            
            foreach (Transaction t in account1.Transactions)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine(account1.Balance);
            Console.WriteLine(account1.Transactions.Count);
        }
    }
}