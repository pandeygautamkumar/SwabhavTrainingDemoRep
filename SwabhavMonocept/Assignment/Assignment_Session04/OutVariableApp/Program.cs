using System;

namespace OutVariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10; ;
            DemoMethod1(ref age);
            Console.WriteLine("Age of the Student of Main Will be : {0}", age);
        }
        private static void DemoMethod1(ref int age)
        {
            age = 45;
            //Console.WriteLine("Age of the Student of DemoMethod1 Will be : {0}", age);
        }
    }
}
