using System;

namespace AccountTransactionApp.Model
{
    internal class Account
    {
        private readonly int _accontNo;
        private double _balance;
        private string _name;
        private const double MIN_BALANCE = 500;
        private readonly List<Transaction> _transactions;
        public Account(int accontNo, string name, double balance)
        {
            _accontNo = accontNo;
            _name = name;
            _balance = balance;
            _transactions = new List<Transaction>();
            _transactions.Add(new Transaction { Type = 'D', Amount = _balance, Time = DateTime.Now });
        }

        public Account(int accontNo, string name):this(accontNo,name,MIN_BALANCE)
        {

        }


        public void Deposit(double amount)
        {
            _balance += amount;
            _transactions.Add(new Transaction { Type = 'D', Amount = _balance, Time = DateTime.Now });
        }

        public void Withdraw(double amount)
        {
            if (HasSufficientFund(amount) == true)
            {
                _balance -= amount;
                _transactions.Add(new Transaction { Type = 'W', Amount = _balance, Time = DateTime.Now });
            }
            else
            {
                throw new Exception("No Fund Available.");
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
        public List<Transaction> Transactions
        {
            get
            {
                return _transactions;
            }
        }
    }
}
