
using RestaurantCoreLib.Order.Food;
using RestaurantCoreLib.Order;

namespace RestaurantClientApp.Model
{
    public class RestaurantFacade
    {
        private IPizza _pizzaProvider;
        private IBread _breadProvider;
        public RestaurantFacade()
        {
            _pizzaProvider = new PizzaProvider();
            _breadProvider = new BreadProvider();
        }
        public void GetNonVegPizza()
        {
            _pizzaProvider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _pizzaProvider.GetVegPizza();
        }
        public void GetGralicBread()
        {
            _breadProvider.GetGarlicBread();
        }
        public void GetChessyBread()
        {
            _breadProvider.GetCheesyBread();
        }
    }
}
