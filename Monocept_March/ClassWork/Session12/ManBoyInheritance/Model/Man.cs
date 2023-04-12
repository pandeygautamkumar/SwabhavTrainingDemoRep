using System;

namespace ManBoyInheritance.Model
{
    internal class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man Play Chess");
        }
        public void Read()
        {
            Console.WriteLine("Man Read Book");
        }
    }
}
