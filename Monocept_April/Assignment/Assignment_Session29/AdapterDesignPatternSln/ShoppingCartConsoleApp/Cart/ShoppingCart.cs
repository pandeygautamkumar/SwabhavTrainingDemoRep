
namespace ShoppingCartConsoleApp.Cart
{
    internal class ShoppingCart
    {
        private List<Item> _items;
        public ShoppingCart()
        {
            _items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if ((_items[i].ItemName() == item.ItemName()) && (_items[i].ItemPrice() == item.ItemPrice()))
                {
                    _items.RemoveAt(i);
                }
            }
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (Item item in _items)
            {
                totalPrice += (item.ItemPrice());
            }
            return totalPrice;
        }
        public List<Item> Items
        {
            get { return _items; }
        }
    }
}
