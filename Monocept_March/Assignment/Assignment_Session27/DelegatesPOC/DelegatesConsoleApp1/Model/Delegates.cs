
namespace DelegatesConsoleApp1.Model
{
    public class Delegates
    {
        public delegate void AddNumber(int num1, int num2);
        public delegate void SubstractNumber(int num1, int num2);
        
        public void Addition(int num1,int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        }
        public void Substraction(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}
