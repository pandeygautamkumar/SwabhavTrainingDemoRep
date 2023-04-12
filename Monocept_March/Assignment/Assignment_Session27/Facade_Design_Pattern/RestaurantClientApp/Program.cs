using RestaurantClientApp.Model;

namespace RestaurantClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            Console.WriteLine("----------------Order Pizza---------------------------");
            var restaurant = new RestaurantFacade();
            restaurant.GetVegPizza();
            restaurant.GetNonVegPizza();
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("----------------Order Bread---------------------------");
            var restaurant = new RestaurantFacade();
            restaurant.GetChessyBread();
            restaurant.GetGralicBread();
        }
    }
}