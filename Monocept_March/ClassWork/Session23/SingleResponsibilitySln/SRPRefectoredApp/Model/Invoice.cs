
namespace SRPViolationApp.Model
{
    internal class Invoice
    {
        private readonly int _id;
        private readonly string _description;
        private readonly double _cost;
        private readonly double _discountPercent;
        private const double _tax = .10;

        public Invoice(int id,string description, double cost, double discountPercent)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = discountPercent;
        }
        public double CalculateTax()
        {
            return (_cost * _tax);
        }
        public double CalculateDiscount()
        {
            return (_cost * _discountPercent);
        }
        public double FinalCost()
        {
            return (_cost + CalculateTax() - CalculateDiscount());
        }
        

        public int Id { get { return _id; } }
        public string Description { get { return _description; } }
        public double Cost { get { return _cost; } }
        public double DiscountPercentage { get { return _discountPercent; } }
    }
}
