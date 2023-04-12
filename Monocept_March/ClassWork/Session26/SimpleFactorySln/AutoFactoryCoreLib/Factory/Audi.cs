using System;
using System.Collections.Generic;
using System;

namespace AutoFactoryCoreLib.Factory
{
    internal class Audi:IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stopping");
        }
    }
}
