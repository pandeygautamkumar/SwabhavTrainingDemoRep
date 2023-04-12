using System;

namespace CollectionApp.Model
{
    internal class LineItem
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _unitPrice;
        private readonly int _quantity;

        public LineItem(int id,string name,double unitPrice,int quantity)
        {
            _id = id;
            _name = name;
            _unitPrice = unitPrice;
            _quantity = quantity;
        }
        public double ItemCost
        {
            get
            {
                return _unitPrice * _quantity;
            }
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }    
        public double UnitPrice { get { return _unitPrice;} }
        public int Quantity { get { return _quantity; } }
    }
}
