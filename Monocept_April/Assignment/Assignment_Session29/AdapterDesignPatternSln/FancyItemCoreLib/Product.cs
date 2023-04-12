
namespace FancyItemCoreLib
{
    public class Product
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private double _gst;
        public Product(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
            _gst =(basePrice*.08);
        }
        public double GetPrice()
        {
            return (_basePrice + _gst);
        }
        public string GetShortName()
        {
            return _shortName;
        }
        public string GetLongName()
        {
            return _longName;
        }
    }
}
