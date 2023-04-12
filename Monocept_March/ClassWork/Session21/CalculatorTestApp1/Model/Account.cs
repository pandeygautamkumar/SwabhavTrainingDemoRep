using System;

namespace AccountApp.Model
{
    internal class Account
    {
        private readonly int _accontNo;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;

        public Account(int accontNo, double balance, string name)
        {
            if (balance < MIN_BALANCE)
                throw new Exception("Not Create Account balance below of 500");
            _accontNo = accontNo;
            _balance = balance;
            _name = name;
        }

        public Account(int acccontNo, string name) {
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
                Console.WriteLine("Error No Fund");
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
