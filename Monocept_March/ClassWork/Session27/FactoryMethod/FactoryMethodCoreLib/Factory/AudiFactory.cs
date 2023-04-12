
using FactoryMethodCoreLib.Factory.Product;

namespace FactoryMethodCoreLib.Factory
{
    public class AudiFactory : IAutomobileFactory
    {
        public IAutoMobile Make()
        {
            return new Audi();
        }
    }
}
