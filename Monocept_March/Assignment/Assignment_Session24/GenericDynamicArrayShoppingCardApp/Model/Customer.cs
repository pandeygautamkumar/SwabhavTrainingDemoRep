﻿
namespace GenericDynamicArrayShoppingCardApp.Model
{
    internal class Customer
    { 
        public Customer(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            Orders = new DynamicArray<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DynamicArray<Order> Orders { get; set; }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public override string ToString()
        {
            return $"Customer Id : {Id}     Customer Name : {Name}  Customer Address : {Address}";
        }
    }
}
