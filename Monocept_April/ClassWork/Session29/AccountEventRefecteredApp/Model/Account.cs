
namespace AccountEventRefecteredApp.Model
{
    internal class Account
    {
        private readonly int _accontNo;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        public event Action<Account> OnBalanceChanged ;
        public Account(int accontNo, double balance, string name)
        {
            _accontNo = accontNo;
            _balance = balance;
            _name = name;
        }

        public Account(int accountNo, string name) : this(accountNo,MIN_BALANCE,name)
        {
         
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(this);
            }
        }

        public void Withdraw(double amount)
        {
            if (HasSufficientFund(amount) == true)
            {
                _balance -= amount;
                if (OnBalanceChanged != null)
                {
                    OnBalanceChanged(this);
                }
            }
            else
            {
                throw new Exception("No fund");
            }
        }
        private bool HasSufficientFund(double balance)
        {
            double amountAfterWithdraw = _balance - balance;
            return (amountAfterWithdraw >= MIN_BALANCE);
        }

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
