
using System.Collections.Generic;

namespace SimpleEFApp.Model
{
    public class Customer
    {
        public Customer()
        {
            Orders=new List<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; }
    }
}
