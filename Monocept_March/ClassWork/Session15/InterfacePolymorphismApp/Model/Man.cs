using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man are Depart.");
        }

        public void Wish()
        {
            Console.WriteLine("Man are Wish.");
        }
    }
}
