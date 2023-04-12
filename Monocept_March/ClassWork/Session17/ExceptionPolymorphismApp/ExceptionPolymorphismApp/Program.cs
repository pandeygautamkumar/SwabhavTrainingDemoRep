using ExceptionPolymorphismApp.Model;

namespace ExceptionPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Gautam Pandey", 500);
            try
            {
                account1.Withdraw(100);
            }/*
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            */
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("End of Main");
        }
    }
}