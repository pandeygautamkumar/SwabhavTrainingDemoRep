using System;

namespace ManBoyInheritance.Model
{
    internal class Boy : Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy Play Cricket");
        }
        public void Eat()
        {
            Console.WriteLine("Boy Eat Burger");
        }
    }
}
