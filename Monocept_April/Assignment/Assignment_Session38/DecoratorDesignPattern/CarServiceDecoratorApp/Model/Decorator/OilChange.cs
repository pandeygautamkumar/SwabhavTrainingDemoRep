
using CarServiceDecoratorApp.Model.Inspection;

namespace CarServiceDecoratorApp.Model.Decorator
{
    public class OilChange
    {
        private ICarService _service;
        public OilChange(ICarService carService)
        {
            _service = carService;
        }
        public double GetCost()
        {
            return 1200 + _service.GetCost();
        }
    }
}
