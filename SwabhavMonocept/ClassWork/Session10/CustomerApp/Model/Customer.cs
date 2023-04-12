using System;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private static int id;
        private int _id;
        private string _name;
        private int _orderCount;

        static Customer()
        {
            id = 1000;
        }
        public Customer(string name,int orderCount)
        {
             id += 1;
            _id = id;
            _name = name;
            _orderCount = orderCount;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int OrderCount
        {
            get
            {
                return _orderCount;
            }
            set
            {
                _orderCount = value;
            }
        }
    }
}
