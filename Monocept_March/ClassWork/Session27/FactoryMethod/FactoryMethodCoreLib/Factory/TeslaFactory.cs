

using FactoryMethodCoreLib.Factory.Product;

namespace FactoryMethodCoreLib.Factory
{
    public class TeslaFactory : IAutomobileFactory
    {
        public IAutoMobile Make()
        {
            return (new Tesla());
        }
    }
}
