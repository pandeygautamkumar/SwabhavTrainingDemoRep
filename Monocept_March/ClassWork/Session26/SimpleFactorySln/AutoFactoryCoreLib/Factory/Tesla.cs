using System;
namespace AutoFactoryCoreLib.Factory
{
    internal class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla Stopping");
        }
    }
}
