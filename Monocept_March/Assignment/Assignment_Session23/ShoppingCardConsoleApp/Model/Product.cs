﻿
namespace ShoppingCardConsoleApp.Model
{
    internal class Product
    {
        public Product(int id, string productName, double price, double discountPercentage)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            DiscountPercentage = discountPercentage;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        
        public double PriceAfterDiscount()
        {
            return Price - ((Price*DiscountPercentage));
        }
        public override string ToString()
        {
            return $"Product Id : {Id}  Product Name : {ProductName}  Product Price : {Price}  PriceAfteDiscount : {PriceAfterDiscount()}";
        }
    }
}
