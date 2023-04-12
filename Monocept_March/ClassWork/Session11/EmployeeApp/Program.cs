using EmployeeApp.Model;
using System;

namespace EmployeeToStringEqualsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var employeeA = new Employee(1, "Gautam", 1000);
            var employeeB = new Employee(1, "Gautam", 1000);
            Console.WriteLine("Reference Base Equality : {0} ", (employeeA == employeeB));
            Console.WriteLine("Value Based Equality : {0}", (employeeA.Equals(employeeB)));
        }

        private static void CaseStudy1()
        {
            var employeeA = new Employee(101, "Gautam", 1000);
            Console.WriteLine(employeeA);
            Console.WriteLine(employeeA.ToString());
            Console.WriteLine(employeeA.GetType().ToString());
        }
    }
}
