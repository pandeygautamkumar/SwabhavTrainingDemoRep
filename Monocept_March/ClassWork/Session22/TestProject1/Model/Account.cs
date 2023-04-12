using AccountTransactionApp.Model;
using System;

namespace AccountCounterApp.Model
{
    internal class Account : Transaction
    {
        private List<Transaction> noOfTrasaction;

        public Account(string type,DateTime time,double amount) : base(type,time,amount)
        {
            noOfTrasaction = new List<Transaction>();
        }

        public void Deposit(double amount)
        {
            _amm += amount;
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
        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
        public static int HeadCount()
        {
            return _instanceCount;
        }
    }
}
