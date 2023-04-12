using System;

namespace AutoFactoryCoreLib.Factory
{
    internal class BMW:IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW Starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Stopping");
        }
    }
}
