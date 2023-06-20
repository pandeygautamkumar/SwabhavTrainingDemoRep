using DepartmentDataLibApp.Model;
using System.ComponentModel.DataAnnotations;
using System;
namespace DepartmentDataCoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            DepartmentRepository repository = new DepartmentRepository();
            //Task.Run(repository.GetAsync);
            Task.Run(repository.CountAsync);
            //Console.ReadLine();
        }

        private static void CaseStudy1()
        {
            DepartmentRepository repository = new DepartmentRepository();
            foreach (var dept in repository.Get())
            {
                Console.Write(dept.Dno+"  ");
                Console.Write(dept.Dname+"  ");
                Console.WriteLine(dept.Location);
            }

            //repository.AddDepartment(new Department
            //{
            //    Dno=1290,
            //    Dname="IT",
            //    Location="Mumbai"
            //});
            Console.WriteLine(repository.CountDepartment());
        }
    }
}