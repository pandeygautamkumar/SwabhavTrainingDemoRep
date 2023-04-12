using DelegatesConsoleApp1.Model;

namespace DelegatesConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegates delegates1 = new Delegates();

            Delegates.AddNumber addition = new Delegates.AddNumber(delegates1.Addition);
            Delegates.SubstractNumber subtraction = new Delegates.SubstractNumber(delegates1.Substraction);

            addition(10, 40);
            subtraction(140, 40);
        }
    }
}