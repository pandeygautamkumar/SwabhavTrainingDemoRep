
namespace ShoppingCardApp.Model
{
    internal class Order
    {
        static Order()
        {
            Count = 0;
        }
        public Order(int id, DateTime craetedDate)
        {
            Id = id;
            CraetedDate = craetedDate;
            Items = new List<lineItem>();
        }
        public int Id { get; set; }
        public DateTime CraetedDate { get; set; }
        public List<lineItem> Items { get; set; }
        public static int Count { get;}

        public void AddItem(lineItem item)
        {
            Items.Add(item);
        }
        public double CalculateCheckOutPrice()
        {
            double checkOutPrice = 0;
            foreach(var item in Items)
            {
                checkOutPrice += item.CalculateItemCost();
            }
            return checkOutPrice;
        }
    }
}
