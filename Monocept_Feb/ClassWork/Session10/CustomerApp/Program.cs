using CustomerApp.Model;
using System;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            Customer c1 = new Customer("A", 10);
            Customer c2 = new Customer("B", 10);
            Customer c3 = new Customer("C", 10);
            Console.WriteLine("Customer A : " + c1.Id);
            Console.WriteLine("Customer B : " + c2.Id);
            Console.WriteLine("Customer C : " + c3.Id);
            Customer c4 = new Customer("D", 10);
            Console.WriteLine("Customer D : " + c4.Id);
        }
    }
}
