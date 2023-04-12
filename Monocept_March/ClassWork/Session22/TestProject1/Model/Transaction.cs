
namespace AccountTransactionApp.Model
{
    internal class Transaction
    {
        private string _type;
        private DateTime _time;
        protected double _amount;
        public Transaction(string type, DateTime time, double amount)
        {
            _type = type;
            _time = time;
            _amount = amount;
        }
    }
}
