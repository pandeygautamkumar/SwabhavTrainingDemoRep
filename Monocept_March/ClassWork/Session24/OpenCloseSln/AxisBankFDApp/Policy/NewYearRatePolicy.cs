
using FixDepositCoreLib.Model;

namespace AxisBankFDApp.Policy
{
    internal class NewYearRatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .07;
        }
    }
}
