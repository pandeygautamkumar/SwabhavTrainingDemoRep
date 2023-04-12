using System;

namespace SimpleInterfaceApp.Model
{
    internal class CustomerRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Records Created.");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Records Deleted.");
        }

        public void Read()
        {
            Console.WriteLine("Customer Records Read.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Records Update.");
        }
    }
}
