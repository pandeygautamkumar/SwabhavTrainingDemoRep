using System;
using System.Collections.Generic;

namespace PublisherCoreLib.Model
{
    public class Account
    {
        private readonly int _accontNo;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private readonly List<IAccountNotifier> _notifications;
        public Account(int accontNo, double balance, string name)
        {
            _accontNo = accontNo;
            _balance = balance;
            _name = name;
            _notifications = new List<IAccountNotifier>();
        }

        public Account(int accontNo, string name) : this(accontNo, MIN_BALANCE, name)
        {

        }
        public void AddSubscriber(IAccountNotifier notifer)
        {
            _notifications.Add(notifer);
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            AddNotification();
        }

        public void Withdraw(double amount)
        {
            if (HasSufficientFund(amount) == true)
            {
                _balance -= amount;
                AddNotification();
            }
            else
            {
                throw new Exception("Error No Fund");
            }
        }
        private void AddNotification()
        {
            foreach (IAccountNotifier notifer in _notifications)
            {
                notifer.Notify(this);
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
