using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class ProductRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Products Records Created.");
        }

        public void Delete()
        {
            Console.WriteLine("Product Record Deleted.");
        }

        public void Read()
        {
            Console.WriteLine("Products Records Read.");
        }

        public void Update()
        {
            Console.WriteLine("Product Record Updated.");
        }
    }
}
