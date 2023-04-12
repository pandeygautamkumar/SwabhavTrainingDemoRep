using System;

namespace AccountLibrary
{
    public class Account
    {
        private readonly int _accontNo;
        private double _balance;
        private string _name;
        private const double MIN_BALANCE = 500;

        public Account(int accontNo, string name, double balance)
        {
            _accontNo = accontNo;
            _name = name;
            _balance = balance;
        }

        public Account(int accontNo, string name) : this(accontNo, name, MIN_BALANCE)
        {

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
            set
            {
                _name = value;
            }
        }
    }
}
