
using FixDepositCoreLib.Model;

namespace HDFCBankFDApp.Policy
{
    internal class Quater2Policy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .10;
        }
    }
}
