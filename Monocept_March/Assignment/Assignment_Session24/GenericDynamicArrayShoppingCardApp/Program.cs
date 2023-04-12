using GenericDynamicArrayShoppingCardApp.Model;

namespace GenericDynamicArrayShoppingCardApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1, "Dmart Order", DateTime.Now);

            lineItem item1 = new lineItem(101, 2, new Product(1001, "Book", 50, .0));
            lineItem item2 = new lineItem(102, 2, new Product(1002, "Pen", 10, .0));

            Customer customer1 = new Customer(1101, "Gautam Kumar Pandey ", "Varanasi");
            customer1.AddOrder(order1);

            PrintCustomerDetails(customer1);
        }
        
        private static void PrintCustomerDetails(Customer customer1)
        {
            Console.WriteLine(customer1);
            Console.WriteLine();

            Console.WriteLine("Total Number Of Order : " + customer1.Orders.Count);

            foreach (var order in customer1.Orders.Get)
            {
                Console.WriteLine(order);
                Console.WriteLine("Total Number Of Order ItemCount : " + order.Items.Count);
                foreach (var item in order.Items.Get)
                {
                    Console.WriteLine("--> " + item);
                    Console.WriteLine("    (" + item.Product + " )");
                }
            }

            Console.WriteLine();
        }
    }
}