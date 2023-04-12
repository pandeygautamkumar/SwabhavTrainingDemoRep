using GenericTypeDynamicArrayApp.Model;

namespace GenericTypeDynamicArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonoceptDynamicArray monoceptDynamicArray = new MonoceptDynamicArray();
            while (true)
            {
                Console.Write("Enter a Number : ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    monoceptDynamicArray.Add(number);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message.ToUpper());
                    Console.ResetColor();
                    break;
                }
            }
            Console.WriteLine("Array  Element Will be : ");
            foreach (int number in monoceptDynamicArray.Get)
            {
                if (number == 0)
                    break;
                Console.Write(number + " ");
            }
        }
    }
}