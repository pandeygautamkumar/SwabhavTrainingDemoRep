
namespace AccountTransactionApp.Model
{
    internal class Transaction
    {
        public char Type { get; set; }
        public DateTime Time { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"Type : {Type}  Time : {Time}  Amount : {Amount}";
        }
    }
}
