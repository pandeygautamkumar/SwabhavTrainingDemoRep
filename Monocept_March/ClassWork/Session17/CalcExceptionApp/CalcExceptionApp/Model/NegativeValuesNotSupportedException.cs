using System;

namespace CalcExceptionApp.Model
{
    internal class NegativeValuesNotSupportedException : Exception
    {
        private int _first;
        private int _second;
        public NegativeValuesNotSupportedException(Calculator calc)
        {
            _first = calc.First;
            _second = calc.Second;
        }
        public override string Message
        {
            get
            {
                if (_first < 0 && _second < 0)
                {
                    return $"Both Number {_first} & {_second} be Negative";
                }

                return $"{((_first < 0) ? _first : _second)} be Negative";
            }
        }

    }
}
