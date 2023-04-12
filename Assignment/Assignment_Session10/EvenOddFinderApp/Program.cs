using EvenOddFinderApp.Model;
using System;

namespace EvenOddFinderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            EvenOdd evenOdd1 = new EvenOdd();
            int[] oddNumbers = evenOdd1.GetOdd(100);
            int[] evenNumbers = evenOdd1.GetEven(100);
            Console.WriteLine(evenOdd1);
            PrintDetails(oddNumbers, "Odd Numbers");
            PrintDetails(evenNumbers, "Even Numbers");
        }

        private static void CaseStudy1()
        {
            EvenOdd evenOdd1 = new EvenOdd();
            int[] oddNumbers = evenOdd1.GetOdd(100, 200);
            int[] evenNumbers = evenOdd1.GetEven(100, 200);
            PrintDetails(oddNumbers, "Odd Numbers");
            PrintDetails(evenNumbers, "Even Numbers");
        }

        private static void PrintDetails(int[] numbers,string description)
        {
            Console.WriteLine(description+" : ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
