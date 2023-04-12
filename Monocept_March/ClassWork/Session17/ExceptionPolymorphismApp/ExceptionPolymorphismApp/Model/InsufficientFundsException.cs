using System;

namespace ExceptionPolymorphismApp.Model
{
    internal class InsufficientFundsException : Exception
    {
        private int _accNo;
        private double _balance, _withdrawAmt;
        private string _name;
        public InsufficientFundsException(int accNo,string name,double balance,double withdrawAmt)
        {
            _accNo=accNo;
            _balance=balance;
            _withdrawAmt=withdrawAmt;
            _name = name;
        }
        /*
        public override string Message
        {
            get
            {
                string message = $"ICICI Bank Say " +
                    $"Account Number : {_accNo} ." +
                    $" Owner : {_name} ." +
                    $" tried Withdrawing : {_withdrawAmt} ." +
                    $" Current Balance is Only : {_balance} ." +
                    $" Minimum balance required has to maintined to 500 ." +
                    $" So this Transaction is Cancelled.";
                return message;
            }
        }*/
    }
}
