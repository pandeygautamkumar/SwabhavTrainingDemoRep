namespace DynamicArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int index = 0;
            while (true)
            {
                if (index == numbers.Length)
                {
                    int prevCapacity = numbers.Length;
                    int[] temporaryArray = numbers;
                    numbers = new int[2 * prevCapacity];
                    for(int j = 0; j < prevCapacity; j++)
                    {
                        numbers[j] = temporaryArray[j];
                    }
                }
                Console.Write("Enter a Number : ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    numbers[index++] = number;
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
            foreach (int number in numbers)
            {
                if (number == 0)
                    break;
                Console.Write(number+" ");
            }
            Console.WriteLine();
        }
    }
}