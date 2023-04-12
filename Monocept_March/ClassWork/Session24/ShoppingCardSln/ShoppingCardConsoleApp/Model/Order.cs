
namespace ShoppingCardConsoleApp.Model
{
    internal class Order
    {
        static Order()
        {
            Count = 0;
        }
        public Order(int id, DateTime createdDate)
        {
            Id = id;
            CreatedDate = createdDate;
            Items = new List<lineItem>();
            Count++;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<lineItem> Items { get; set; }
        public static int Count { get; set; }

        public void AddItem(lineItem item)
        {
            Items.Add(item);
        }
        public double CalculateCheckOutPrice()
        {
            double checkOutPrice = 0;
            foreach(var item in Items)
            {
                checkOutPrice+=item.CalculateItemCost();
            }
            return checkOutPrice;
        }

        public override string ToString()
        {
            return $"Order Id : {Id}  OrderCreated Date : {CreatedDate}  TotalItemCost : {CalculateCheckOutPrice()}";
        }
    }
}
