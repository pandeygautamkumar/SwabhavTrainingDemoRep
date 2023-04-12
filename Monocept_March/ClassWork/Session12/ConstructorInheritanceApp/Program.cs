using ConstructorInheritanceApp.Model;
using System;

namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            var childA = new ChildV2();
            Console.WriteLine(childA.Age);
            var childB = new ChildV2();
            Console.WriteLine(childB.Age);
        }

        private static void CaseStudy2()
        {
            int age = 10;
            ChildV1 childV2 = new ChildV1(age);
            Console.WriteLine(childV2.Age);
        }

        private static void CaseStudy1()
        {
            ChildV1 childV1=new ChildV1();
        }
    }
}
