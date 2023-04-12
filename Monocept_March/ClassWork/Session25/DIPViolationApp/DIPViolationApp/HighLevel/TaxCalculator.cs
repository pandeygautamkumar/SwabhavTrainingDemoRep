
using DIPViolationApp.LowLevel;

namespace DIPViolationApp.HighLevel
{
    internal class TaxCalculator : IErrorLogger
    {
        private IErrorLogger _errorLogger;
        public TaxCalculator(ErrorLogOptions errorLogOptions)
        {
            _errorLogOptions = errorLogOptions;
        }
        public int CalculateTax(int income,int rate)
        {
            int result = -1;
            try
            {
                result = income / rate;
            }
            catch(Exception ex)
            {
                if (_errorLogOptions == ErrorLogOptions.TEXT)
                {
                    var txtLogger = new TextErrorLogger();
                    txtLogger.Log(ex);
                }
                else
                {
                    var xmlLogger = new XMLErrorLogger();
                    xmlLogger.Log(ex);
                }
            }
            return result;
        }

        public void Log(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
