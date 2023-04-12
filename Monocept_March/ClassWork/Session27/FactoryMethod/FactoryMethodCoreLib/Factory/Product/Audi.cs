using System;

namespace FactoryMethodCoreLib.Factory.Product
{
    internal class Audi : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi Starting"  );
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stopping");
        }
    }
}
