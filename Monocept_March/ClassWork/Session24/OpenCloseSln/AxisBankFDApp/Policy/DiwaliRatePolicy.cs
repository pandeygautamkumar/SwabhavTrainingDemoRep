
using FixDepositCoreLib.Model;

namespace AxisBankFDApp.Policy
{
    internal class DiwaliRatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .08;
        }
    }
}
