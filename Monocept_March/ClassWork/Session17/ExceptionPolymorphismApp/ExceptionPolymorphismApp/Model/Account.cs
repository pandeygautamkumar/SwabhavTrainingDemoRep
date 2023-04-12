using System;

namespace ExceptionPolymorphismApp.Model
{
    internal class Account
    {
        private readonly int _accontNo;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;

        public Account(int accontNo, string name, double balance)
        {
            _accontNo = accontNo;
            _balance = balance;
            _name = name;
        }

        public Account(int acccontNo, string name)
        {
            _accontNo = acccontNo;
            _name = name;
            _balance = MIN_BALANCE;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (HasSufficientFund(amount) == true)
            {
                _balance -= amount;
            }
            else
            {
                throw new InsufficientFundsException(_accontNo, _name, _balance, amount);
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
