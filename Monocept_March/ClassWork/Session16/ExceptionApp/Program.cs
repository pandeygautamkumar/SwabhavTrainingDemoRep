namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstValue = int.Parse(args[0]);
            int secondValue = int.Parse(args[1]);
            int result = firstValue / secondValue;
            Console.WriteLine("{0}/{1}={2}",firstValue,secondValue,result);
            Main(args);
        }
    }
}