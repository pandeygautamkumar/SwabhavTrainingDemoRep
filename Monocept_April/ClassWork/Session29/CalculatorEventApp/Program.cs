using CalculatorEventApp.Model;

namespace CalculatorEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.AdditionCompleted += PrintResult;
            calc.Add(10, 30);
            calc.Add(100, 200);

            calc.SubstractionCompleted += PrintResult;
            calc.Substract(10,5);
        }
        private static void PrintResult(int n1,int n2,string result)
        {
            Console.WriteLine(result);
        }
    }
}