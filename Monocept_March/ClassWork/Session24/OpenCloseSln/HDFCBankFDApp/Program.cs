using FixDepositCoreLib.Model;
using HDFCBankFDApp.Policy;

namespace HDFCBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1, "Gautam", 400000, 8, new Quater2Policy());
            Console.WriteLine(fd1.SimpleInterest);

            FixedDeposit fd2 = new FixedDeposit(2, "Gautam", 300000, 8, new Quater1Policy());
            Console.WriteLine(fd2.SimpleInterest);
        }
    }
}