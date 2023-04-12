
using DIPViolationApp.LowLevel;

namespace DIPViolationApp.HighLevel
{
    delegate void DLogger(Exception exception);
    internal class TaxCalculator
    {
        private DLogger _dLogger;
        public TaxCalculator(DLogger logger)
        {
            _dLogger = logger;
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
                _dLogger(ex);
            }
            return result;
        }
    }
}
