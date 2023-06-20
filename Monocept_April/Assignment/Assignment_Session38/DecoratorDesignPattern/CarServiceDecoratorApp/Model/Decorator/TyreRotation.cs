
using CarServiceDecoratorApp.Model.Inspection;

namespace CarServiceDecoratorApp.Model.Decorator
{
    public class TyreRotation
    {
        private ICarService _service;
        public TyreRotation(ICarService carService)
        {
            _service = carService;
        }
        public double GetCost()
        {
            return 350 + _service.GetCost();
        }
    }
}
