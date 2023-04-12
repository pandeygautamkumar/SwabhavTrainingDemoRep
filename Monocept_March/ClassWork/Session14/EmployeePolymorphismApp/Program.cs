using EmployeePolymorphismApp.Model;
using System;
using System.IO;

namespace EmployeePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerCaseStudy();
            DeveloperCaseStudy();
        }

        private static void DeveloperCaseStudy()
        {
            Developer developer1 = new Developer(1001, "Ravi", 15000);
            PrintSalarySlipAsConsole(developer1);
            PrintSalarySlipAsHTMLFile(developer1);
        }

        private static void ManagerCaseStudy()
        {
            Manager manager1 = new Manager(1001, "Abc", 30000);
            PrintSalarySlipAsConsole(manager1);
            PrintSalarySlipAsHTMLFile(manager1);
            
        }

        private static void PrintSalarySlipAsHTMLFile(Employee employee)
        {
            StreamWriter sw = new StreamWriter(employee.Name + ".html");
            sw.WriteLine("<body>");
            sw.WriteLine("<ol>");
            sw.WriteLine("<li>");
            sw.WriteLine("Employee ID :{0}",employee.Id);
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine("Employee Name :{0}", employee.Name);
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine("Employee Basic Salary :{0}", employee.BasicSalary);
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine("Employee CTC :{0}", employee.CostToCompany);
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine("Employee Role :{0}", employee.Role);
            sw.WriteLine("</li>");
            sw.WriteLine("<li>");
            sw.WriteLine("Employee Salary BreakUp :{0}", employee.SalaryBreakUp);
            sw.WriteLine("</li>");
            sw.WriteLine("</ol>");
            sw.WriteLine("</H1>");
            sw.WriteLine("</body>");
            sw.WriteLine("<H1>");
            sw.Close();
            Console.WriteLine("Written to File");
        }
        private static void PrintSalarySlipAsConsole(Employee employee)
        {
            Console.WriteLine("Employee Id is : " + employee.Id);
            Console.WriteLine("Employee Name is : " + employee.Name);
            Console.WriteLine("Employee Basic Salary is : " + employee.BasicSalary);
            Console.WriteLine("Employee CTC is : " + employee.CostToCompany);
            Console.WriteLine("Employee Role is : " + employee.Role);
            Console.WriteLine("Employee Salary Breakup is : " + employee.SalaryBreakUp);
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
