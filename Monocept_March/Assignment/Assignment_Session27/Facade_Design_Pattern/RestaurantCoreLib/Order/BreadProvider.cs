
using RestaurantCoreLib.Order.Food;
using System;

namespace RestaurantCoreLib.Order
{
    public class BreadProvider : IBread
    {
        public void GetCheesyBread()
        {
            Console.WriteLine("Getting Cheesy Bread.");
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
    }
}
