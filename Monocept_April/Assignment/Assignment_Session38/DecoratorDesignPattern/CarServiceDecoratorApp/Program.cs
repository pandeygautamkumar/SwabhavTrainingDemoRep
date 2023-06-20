using CarServiceDecoratorApp.Model.Decorator;
using CarServiceDecoratorApp.Model.Inspection;

namespace CarServiceDecoratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OilChange oil_change=new OilChange( new CarInspection());
            Console.WriteLine("Oil Changing Cost Will be : {0}",oil_change.GetCost());

            TyreRotation tyreRotation = new TyreRotation(new CarInspection());
            Console.WriteLine("Tyre Rotation Cost Will be : {0}", tyreRotation.GetCost());
        }
    }
}