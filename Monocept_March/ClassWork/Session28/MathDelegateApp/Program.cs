namespace MathDelegateApp
{
    delegate void DMatOperations(int n1, int n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            DMatOperations obj = Addition;
            obj += Substraction;
            obj += Multiplication;
            obj += Division;
            obj += Remender;

            obj(5,2);
        }
        private static void Addition(int n1,int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }
        private static void Substraction(int n1, int n2)
        {
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        }
        private static void Multiplication(int n1, int n2)
        {
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
        }
        private static void Division(int n1, int n2)
        {
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        }
        private static void Remender(int n1, int n2)
        {
            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
        }
    }
}