using System;

namespace ConstructorInheritanceApp.Model
{
    internal class ParentV2
    {
        private int _age;
        public ParentV2(int age)
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
