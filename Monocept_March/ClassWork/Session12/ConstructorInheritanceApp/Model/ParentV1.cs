using System;

namespace ConstructorInheritanceApp.Model
{
    internal class ParentV1
    {
        private int _age;
        public ParentV1()
        {
            Console.WriteLine("Parent Class Constructor Will be Call.");
        }
        public ParentV1(int age)
        {
            _age = age;
            Console.WriteLine("Parent Class Constructor Will be Call.");
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
    }
}
