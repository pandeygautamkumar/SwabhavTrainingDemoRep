using System;
using System.Diagnostics.CodeAnalysis;

namespace ParamsArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sum of Element Will be :");
            Console.WriteLine(Add(10, 20, 30, 40, 50));
        }
        private static int Add(params int[] numbers)// 
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
