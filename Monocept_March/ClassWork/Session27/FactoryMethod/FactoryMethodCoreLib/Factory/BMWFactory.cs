
using FactoryMethodCoreLib.Factory.Product;

namespace FactoryMethodCoreLib.Factory
{
    public class BMWFactory : IAutomobileFactory
    {
        public IAutoMobile Make()
        {
            return (new BMW());
        }
    }
}
