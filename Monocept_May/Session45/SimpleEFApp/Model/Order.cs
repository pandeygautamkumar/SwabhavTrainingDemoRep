

using System;

namespace SimpleEFApp.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
    }
}
