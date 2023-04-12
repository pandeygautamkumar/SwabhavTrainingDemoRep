using System;

namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] numberOfArgs)
        {
            Console.WriteLine("Inside Main");
            Console.WriteLine(numberOfArgs.Length);
            for(int i = 0; i < numberOfArgs.Length; i++)
            {
                Console.WriteLine("Hello " + numberOfArgs[i]);
            }
            Console.WriteLine("End of Main");
        }
    }
}
