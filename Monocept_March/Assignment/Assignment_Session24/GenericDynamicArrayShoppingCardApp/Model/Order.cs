
namespace GenericDynamicArrayShoppingCardApp.Model
{
    internal class Order
    {
        public Order(int id, string orderName, DateTime createdDate)
        {
            Id = id;
            OrderName = orderName;
            CreatedDate = createdDate;
            Items = new DynamicArray<lineItem>();
        }
        public int Id { get; set; }
        public string OrderName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DynamicArray<lineItem> Items { get; set; }

        public void AddItem(lineItem currentItem)
        {
            Items.Add(currentItem);
        }

        public double CalculateCheckOutPrice()
        {
            double checkOutPrice = 0;
            foreach (var item in Items.Get)
            {
                checkOutPrice += item.CalculateItemCost();
            }
            return checkOutPrice;
        }

        public override string ToString()
        {
            return $"Order Id : {Id}   Order Name is : {OrderName}   OrderCreated Date : {CreatedDate}  TotalItemCost : {CalculateCheckOutPrice()}";
        }
    }
}
