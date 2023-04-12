using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Boy : IMannerable,IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Boy are Cry.");
        }

        public void Depart()
        {
            Console.WriteLine("Boy are Depart.");
        }

        public void Laught()
        {
            Console.WriteLine("Boy are Laught.");
        }

        public void Wish()
        {
            Console.WriteLine("Boy are Wishes.");
        }
    }
}
