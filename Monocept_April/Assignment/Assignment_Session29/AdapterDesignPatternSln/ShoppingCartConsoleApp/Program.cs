using FancyItemCoreLib;
using ShoppingCartConsoleApp.Cart;

namespace ShoppingCartConsoleApp
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
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new ProductAdapter(new Product("Hat", "Golden Premium Hat", 999)));
            shoppingCart.AddItem(new ProductAdapter(new Product("Book", "10th Standard Book", 450)));
            shoppingCart.AddItem(new ProductAdapter(new Product("Pen", "Premium Pen", 15)));
            shoppingCart.AddItem(new ProductAdapter(new Product("Paper", "Sample Paper", 10)));

            shoppingCart.RemoveItem(new ProductAdapter(new Product("Paper", "Sample Paper", 10)));

            PrintDetails(shoppingCart);
        }

        private static void CaseStudy1()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new ProductAdapter(new Product("Hat", "Golden Premium Hat", 999)));
            shoppingCart.AddItem(new ProductAdapter(new Product("Book", "10th Standard Book", 450)));
            shoppingCart.AddItem(new ProductAdapter(new Product("Pen", "Premium Pen", 15)));
            shoppingCart.AddItem(new ProductAdapter(new Product("Paper", "Sample Paper", 10)));

            PrintDetails(shoppingCart);
        }

        private static void PrintDetails(ShoppingCart shoppingCart)
        {
            Console.WriteLine("No of Product in Cart : " + shoppingCart.Items.Count);
            foreach(Item item in shoppingCart.Items)
            {
                Console.WriteLine($"-->Item Name is : {item.ItemName()}   Item Price is : {item.ItemPrice()}");
            }
            Console.WriteLine();
            Console.WriteLine("Total Price is : " + shoppingCart.TotalPrice());
        }
    }
}