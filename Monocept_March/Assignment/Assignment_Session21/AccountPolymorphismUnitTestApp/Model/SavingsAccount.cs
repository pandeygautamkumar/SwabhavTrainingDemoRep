
namespace AccountPolymorphismApp.Model
{
    internal class SavingsAccount : Account
    {
        private const int MIN_BALANCE = 1000;
        public SavingsAccount(int accountNo,string name,double balance) : base(accountNo, name, balance)
        {
            
        }
        public override void Withdraw(double amount)
        {
            if (SufficientAmount(amount))
            {
                _balance = _balance - amount;
                return;
            }
            throw new Exception("No Sufficeient Funds");
        }
        private bool SufficientAmount(double amount)
        {
            return (_balance - amount > MIN_BALANCE);
        }
    }
}
