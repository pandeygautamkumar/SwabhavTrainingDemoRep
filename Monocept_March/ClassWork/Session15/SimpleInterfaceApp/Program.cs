using SimpleInterfaceApp.Model;
using System;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoOperations(new CustomerRepository());
            DoOperations(new ProductRepository());
            DoOperations(new DepartmentRepository());
        }
        public static void DoOperations(ICrudable crudable)
        {
            Console.WriteLine();
            crudable.Create();
            crudable.Read();
            crudable.Delete();
            crudable.Update();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
