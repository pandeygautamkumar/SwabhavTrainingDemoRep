using CalcExceptionApp.Model;

namespace CalcExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstNegative();
            SecondNegative();
            BothNegative();
            BothPositive();
        }

        private static void BothPositive()
        {
            try
            {
                Calculator calc = new Calculator();
                Console.WriteLine("Addition of Two Number is : " + (calc.Add(10, 20)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BothNegative()
        {
            try
            {
                Calculator calc = new Calculator();
                Console.WriteLine("Addition of Two Number is : " + (calc.Add(-10, -20)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void FirstNegative()
        {
            try
            {
                Calculator calc = new Calculator();
                Console.WriteLine("Addition of Two Number is : " + (calc.Add(-10, 20)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SecondNegative()
        {
            try
            {
                Calculator calc = new Calculator();
                Console.WriteLine("Addition of Two Number is : " + (calc.Add(4, -14)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}