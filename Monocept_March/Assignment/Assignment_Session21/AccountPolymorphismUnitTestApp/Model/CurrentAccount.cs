
namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccount : Account
    {
        private const int OVER_DRAFT_LIMIT = -5000;
        public CurrentAccount(int accontNo, string name, double balance) : base(accontNo, name, balance)
        {
            
        }

        public override void Withdraw(double amount)
        {
            if (SufficientAmount(amount))
            {
                _balance -= amount;
                return;
            }
            throw new Exception("OverDraft Limit Has Been Excceded");
        }
        private bool SufficientAmount(double amount)
        {
            return (_balance - amount >= OVER_DRAFT_LIMIT);
        }
    }
}
