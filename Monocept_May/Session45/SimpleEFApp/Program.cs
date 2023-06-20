
using SimpleEFApp.EF;
using SimpleEFApp.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace SimpleEFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
            CaseStudy5();
            Console.ReadLine();
        }
        private static void CaseStudy5()
        {
            var db = new CustomerDbContext();
            foreach (var d in db.Departments.Include(e => e.Employees))
            {
                Console.WriteLine($"Department ID: {d.Id}   Department Name : {d.DName}");
                foreach (var e in d.Employees)
                {
                    Console.WriteLine($"-->Employee Id : {e.Id}   Employee Name : {e.EName}  Employee Address : {e.Address}");
                }
            }
        }
        private static void CaseStudy4()
        {
            var db = new CustomerDbContext();

            var dept = new Department(); ;
            dept.DName = "IT";

            var e1 = new Employee();
            e1.EName = "Gautam";
            e1.Address = "Hyderabad";
            e1.Department= dept;
            

            var e2 = new Employee(); ;
            e2.EName = "Vikarnt";
            e2.Address = "Mumbai";
            e2.Department = dept;

            dept.Employees.Add(e1);
            dept.Employees.Add(e2); 

            db.Departments.Add(dept);
            db.SaveChanges();
        }
        private static void CaseStudy3()
        {
            var db = new CustomerDbContext();
            foreach(var c in db.Customers.Include(c=>c.Orders))
            {
                Console.WriteLine($"Customer ID: {c.Id}   Customer Name : {c.Name}   Customer Address: {c.Address}");
                foreach(var o in c.Orders)
                {
                    Console.WriteLine($"-->Order Id : {o.Id}   Order Date : {o.Date}   Order Description : {o.Description}");
                }
            }
        }
        private async static void CaseStudy2()
        {
            var db = new CustomerDbContext();
            await db.Orders.ForEachAsync(o => Console.WriteLine($"Order Id : {o.Id}   Order Date : {o.Date}" +
                $"   Order Description : {o.Description}   Ordered Customer: {o.Customer}"));
        }
        private static void CaseStudy1()
        {
            var db = new CustomerDbContext();

            var c1 = new Customer();
            c1.Name = "Gautam";
            c1.Address = "Hyderabad";

            var order1=new Order(); ;
            order1.Date = DateTime.Now;
            order1.Description = "Books";
            order1.Customer = c1;

            var order2 = new Order(); ;
            order2.Date = DateTime.Now;
            order2.Description = "Electronics";
            order2.Customer = c1;

            c1.Orders.Add(order1);
            c1.Orders.Add(order2);

            db.Customers.Add(c1);
            db.SaveChanges();
        }
    }
}
