using System;

namespace InVariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 45;
            DemoMethod1(in age);
            Console.WriteLine("Age of Student Will be :{0}", age);
        }
        private static void DemoMethod1(in int age)
        {
            //age = 60;
            Console.WriteLine("Age of Student Will be :{0}", age);
        }
    }
}
