
namespace FixDepositCoreLib.Model
{
    public class FixedDeposit
    {
        private int _accNo;
        private string _name;
        private double _principleAmount;
        private int _duration;
        private IRatePolicy _ratePolicy;
        public FixedDeposit(int accNo,string name,double principleAmount,int duration,IRatePolicy ratePolicy)
        {
            _accNo = accNo;
            _name = name;
            _principleAmount = principleAmount;
            _duration = duration;
            _ratePolicy = ratePolicy;
        }
        public double SimpleInterest
        {
            get
            {
                return (_principleAmount * _duration * _ratePolicy.CalculateRate());
            }
        }
    }
}
