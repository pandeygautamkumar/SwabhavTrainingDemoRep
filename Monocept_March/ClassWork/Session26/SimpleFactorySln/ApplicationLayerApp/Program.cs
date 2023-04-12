using AutoFactoryCoreLib.Factory;

namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory = new AutoMobileFactory();
            IAutoMobile auto = factory.Make(AutoOption.AUDI);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());
        }
    }
}