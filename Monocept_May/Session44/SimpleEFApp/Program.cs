
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
            //CaseStudy4();
            //CaseStudy5();
            //CaseStudy6();
            CaseStudy7();

            Console.ReadLine();
        }
        private static void CaseStudy1()
        {
            var c1 = new Customer { Name = "Vikarant", Address = "Moncept" };
            var c2 = new Customer { Name = "Anikant", Address = "Moncept" };
            var db = new CustomerDbContext();
            db.customers.Add(c1);
            db.customers.Add(c2);
            db.SaveChanges();
        }
        private static void CaseStudy2()
        {
            // Big Performance Problem
            var db = new CustomerDbContext();
            var customers = db.customers.ToList();
            var customer=customers.Where(c => c.Name.Equals("Anikant")).First();
            Console.WriteLine(customer.Name);   
        }
        private static void CaseStudy3()
        {
            var db = new CustomerDbContext();
            var customer =db.customers.Where(c => c.Name.Equals("Anikant")).ToList();
            customer.ForEach(c=>Console.WriteLine(c.Name));    
        }
        private static void CaseStudy4()
        {
            var db = new CustomerDbContext();
            db.customers.ForEachAsync<Customer>(c => Console.WriteLine($"{c.Id}\t\t{c.Name}\t\t{c.Address}"));
        }
        private static void CaseStudy5()
        {
            var db = new CustomerDbContext();
            var customer=db.customers
                .Where(c => c.Name.Equals("Anikant"))
                .First();
            customer.Address = customer.Address + " ,Hyderabad";
            customer.Name = customer.Name.ToUpper();
            db.SaveChanges();
        }
        private async static void CaseStudy6()
        {
            //string name = "Sachin Tendulaker";
            //string name = "Sachin";
            //Console.WriteLine(name.Split()[0]);

            // Cannot Convert String expression to sqlExpression 

            var db = new CustomerDbContext();
            var customer = db.customers.Select(c => new
            {
                FirstName = c.Name.Split()[0],
                LastName = c.Name.Split()[1]
            });
            await customer.ForEachAsync(c => Console.WriteLine($"{c.FirstName}   {c.LastName}"));
        }
        private static void CaseStudy7()
        {

            var db = new CustomerDbContext();
            var customer = db.customers.ToList()
                .Select(c => new
            {
                FirstName = c.Name.Split()[0]
                //LastName = c.Name.Split()[1]
            });
            customer.ToList().ForEach(c => Console.WriteLine($"{c.FirstName}"));
        }
    }
}
