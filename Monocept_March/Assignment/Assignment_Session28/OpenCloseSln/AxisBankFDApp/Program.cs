using AxisBankFDApp.Policy;
using FixDepositCoreLib.Model;

namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1, "Gautam", 100000, 10, new DiwaliRatePolicy().CalculateRate);
            Console.WriteLine(fd1.SimpleInterest);

            FixedDeposit fd2 = new FixedDeposit(2, "Gautam", 200000, 10, new NewYearRatePolicy().CalculateRate);
            Console.WriteLine(fd2.SimpleInterest);
            
        }
    }
}