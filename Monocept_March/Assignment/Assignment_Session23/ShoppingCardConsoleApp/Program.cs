using ShoppingCardConsoleApp.Model;

namespace ShoppingCardConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Laptop", 45000, .12);
            Product p2 = new Product(2, "Milk", 25.50, .10);
            Product p3 = new Product(3, "Shop", 10, .05);

            Order order = new Order(10001, DateTime.Now);

            order.AddItem(new lineItem(101, p1, 3));
            order.AddItem(new lineItem(102, p2, 3));
            order.AddItem(new lineItem(103, p3, 3));

            Customer customer1 = new Customer(1101, "Gautam", "Varanasi");
            customer1.AddOrder(order);
            PrintCustomerDetails(customer1);
        }

        private static void PrintCustomerDetails(Customer customer1)
        {
            Console.WriteLine(customer1);
            Console.WriteLine("Total Number Of Order : " + Order.Count);
            foreach(var order in customer1.Orders)
            {
                Console.WriteLine(order);
                foreach(var item in order.Items)
                {
                    Console.WriteLine("--> "+item);
                    Console.WriteLine("    (" + item.Product+" )");
                }
            }
            Console.WriteLine();
        }
    }
}