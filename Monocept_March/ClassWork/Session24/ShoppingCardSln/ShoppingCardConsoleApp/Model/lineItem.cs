﻿
namespace ShoppingCardConsoleApp.Model
{
    internal class lineItem
    {
        public lineItem(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double CalculateItemCost()
        {
            return (Quantity*Product.PriceAfterDiscount());
        }

        public override string ToString()
        {
            return $"Item ID: {Id}  Item Name : {Product.ProductName}  Quantity : {Quantity} ";
        }
    }
}
