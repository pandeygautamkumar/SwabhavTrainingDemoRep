
namespace AccountPolymorphismApp.Model
{
    internal abstract class Account
    {
        private readonly int _accontNo;
        protected double _balance;
        private readonly string _name;
        public Account(int accontNo, string name, double balance)
        {
            _accontNo = accontNo;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);

        public double AccountNo
        {
            get
            {
                return _accontNo;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
