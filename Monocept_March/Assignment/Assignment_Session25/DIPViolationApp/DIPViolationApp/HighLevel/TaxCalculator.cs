
using DIPViolationApp.LowLevel;

namespace DIPViolationApp.HighLevel
{
    internal class TaxCalculator
    {
        private IErrorLogger _errorLogger;
        public TaxCalculator(IErrorLogger errorOptions)
        {
            _errorLogger = errorOptions;
        }
        public int CalculateTax(int income, int rate)
        {
            int result = -1;
            try
            {
                result = income / rate;
            }
            catch (Exception ex)
            {
                _errorLogger.Log(ex);
            }
            return result;
        }
    }
}
