
using FixDepositCoreLib.Model;

namespace HDFCBankFDApp.Policy
{

    internal class Quater1Policy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .12;
        }
    }
}
