
namespace CarServiceDecoratorApp.Model.Inspection
{
    public class CarInspection : ICarService
    {
        public double GetCost()
        {
            return 250;
        }
    }
}
