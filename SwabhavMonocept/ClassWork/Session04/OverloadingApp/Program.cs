using System;

namespace OverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(50);
            PrintDetails(10.55);
            PrintDetails(10.55f);
            PrintDetails("Monocept");
            PrintDetails('a');
            PrintDetails('A');
            PrintDetails(10 > 5);
            PrintDetails(40, 50);
        }
        private static void PrintDetails(int input)
        {
            Console.WriteLine("Printing Integer input {0} ,double: {1} ", input, 2 * input);
        }
        private static void PrintDetails(double input)
        {
            Console.WriteLine("Printing a double value , value is {0} ", input);
        }
        private static void PrintDetails(float input)
        {
            Console.WriteLine("Printing a float value , value is {0} ", input);
        }
        private static void PrintDetails(string input)
        {
            Console.WriteLine("Printing a string {0} ", input);
        }
        private static void PrintDetails(char input)
        {
            Console.WriteLine("Printing a character value {0}, Ascii value is {1} : ", input, (int)input);
        }
        private static void PrintDetails(bool input)
        {
            Console.WriteLine("Printing a boolean Value {0} : ", input);
            Console.WriteLine();
        }
        private static void PrintDetails(int first,int second)
        {
            Console.WriteLine("First : {0}  Second : {1} ", first,second);
        }
    }
}
 