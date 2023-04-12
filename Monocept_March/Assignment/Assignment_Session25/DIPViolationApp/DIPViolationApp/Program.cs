using DIPViolationApp.HighLevel;
using DIPViolationApp.LowLevel;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(new XMLErrorLogger());
            Console.WriteLine(calc.CalculateTax(10, 2));
            Console.WriteLine(calc.CalculateTax(10, 0));

            calc= new TaxCalculator(new TextErrorLogger());
            Console.WriteLine(calc.CalculateTax(20, 0));
        }
    }
}