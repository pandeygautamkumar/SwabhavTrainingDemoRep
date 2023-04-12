using System;

namespace ConstructorInheritanceApp.Model
{
    internal class ChildV1 : ParentV1
    {
        public ChildV1():base()
        {
            Console.WriteLine("Child Class Constructor Will be Call.");
        }
        public ChildV1(int age):base(age)
        {
            Console.WriteLine("Child Class Constructor Will be Call.");
        }
    }
}
