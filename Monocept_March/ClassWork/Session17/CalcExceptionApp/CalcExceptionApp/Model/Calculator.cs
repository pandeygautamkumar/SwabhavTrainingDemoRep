using System;

namespace CalcExceptionApp.Model
{
    internal class Calculator
    {
        private int _first;
        private int _second;
        public int First
        {
            get
            {
                return _first;
            }
        }
        public int Second
        {
            get
            {
                return _second;
            }
        }
        public int Add(int first, int second)
        {
            _first = first;
            _second = second;

            if (_first >= 0 && _second >= 0)
            {
                return (_first + _second);
            }

            throw new NegativeValuesNotSupportedException(this);
        }
    }
}
