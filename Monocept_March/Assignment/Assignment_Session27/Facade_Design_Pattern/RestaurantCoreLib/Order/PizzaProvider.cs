
using RestaurantCoreLib.Order.Food;
using System;

namespace RestaurantCoreLib.Order
{
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            Console.WriteLine("Getting Non-Veg Pizza.");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }
    }
}
