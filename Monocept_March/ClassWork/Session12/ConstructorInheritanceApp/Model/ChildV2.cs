using System;

namespace ConstructorInheritanceApp.Model
{
    internal class ChildV2 : ParentV2
    {
        public ChildV2() : base(100)
        {
            Console.WriteLine("Child Class Constructor Will be Call.");
        }
    }
}
