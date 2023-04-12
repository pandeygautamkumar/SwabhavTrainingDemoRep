
using FancyItemCoreLib;

namespace ShoppingCartConsoleApp.Cart
{
    internal class ProductAdapter : Item
    {
        private Product _product;
        public ProductAdapter(Product product)
        {
            _product = product;
        }

        public string ItemName()
        {
            return _product.GetShortName();
        }

        public double ItemPrice()
        {
            return _product.GetPrice();
        }
    }
}
