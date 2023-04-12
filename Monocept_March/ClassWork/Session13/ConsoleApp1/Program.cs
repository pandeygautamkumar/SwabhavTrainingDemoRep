using EmployeePolymorphism.Model;
using System;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager(1001, "Abc", 30000, 40, 50, 60);
            PrintSalarySlip(manager1, "Manager Details");
            Console.WriteLine("Manager Annual Salary Will Be : "+manager1.CalculateAnnualSalary());
        }
        private static void PrintSalarySlip(Employee employee,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Employee Id is : "+employee.Id);
            Console.WriteLine("Employee Name is : "+employee.Name);
            Console.WriteLine("Employee Basic Salary is : "+ employee.BasicSalary);
        }
    }
}
