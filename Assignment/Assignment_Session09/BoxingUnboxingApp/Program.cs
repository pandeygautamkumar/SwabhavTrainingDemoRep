using System;

namespace BoxingUnboxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unboxing();
            Boxing();
        }

        private static void Unboxing()
        {
            Object obj = 40;
            Console.WriteLine("Object is before : " + obj);
            int num = (int)obj;
            Console.WriteLine("Object After Unboxing : " + num);
        }

        private static void Boxing()
        {
            int number = 2023;
            object obj = null;
            Console.WriteLine("Number is before : " + number);
            Console.WriteLine("Obj is before: " + obj);
            obj = number;
            number = 200;
            Console.WriteLine("Number is after : " + number);
            Console.WriteLine("Obj is after : " + obj);
        }
    }
}
