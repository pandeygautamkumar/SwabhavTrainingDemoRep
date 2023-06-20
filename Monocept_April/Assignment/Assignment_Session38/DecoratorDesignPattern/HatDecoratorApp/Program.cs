using HatDecoratorApp.Model;
using HatDecoratorApp.Model.Decorators;
using HatDecoratorApp.Model.Hats;

namespace HatDecoratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HatDecorator hat_decorator = new GoldenHat(new StandardHad());
            PrintHatDetail(hat_decorator);

            hat_decorator = new GoldenHat(new PremiumHat());
            PrintHatDetail(hat_decorator);

            hat_decorator = new RibbonedHat(new StandardHad());
            PrintHatDetail(hat_decorator);

            hat_decorator = new RibbonedHat(new PremiumHat());
            PrintHatDetail(hat_decorator);
        }
        private static void PrintHatDetail(IHat hat)
        {
            Console.WriteLine("Hat Name: " + hat.GetName());
            Console.WriteLine("Hat Price: " + hat.GetPrice());
            Console.WriteLine("Hat Description: " + hat.GetDescription());
            Console.WriteLine();
        }
    }
}