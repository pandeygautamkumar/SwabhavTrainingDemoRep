using FactoryMethodCoreLib.Factory;
using FactoryMethodCoreLib.Factory.Product;

namespace FactoryMethodClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutomobileFactory factory1 = new TeslaFactory();
            IAutoMobile auto = factory1.Make();
            auto.Start();
            auto.Stop();
        }
    }
}