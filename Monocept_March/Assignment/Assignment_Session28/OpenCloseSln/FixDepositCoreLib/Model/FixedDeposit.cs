
namespace FixDepositCoreLib.Model
{
    public delegate double DCalculateRate();
    public class FixedDeposit
    {
        private int _accNo;
        private string _name;
        private double _principleAmount;
        private int _duration;
        private DCalculateRate _rate;
        public FixedDeposit(int accNo,string name,double principleAmount,int duration,DCalculateRate rate)
        {
            _accNo = accNo;
            _name = name;
            _principleAmount = principleAmount;
            _duration = duration;
            _rate=rate;
        }
        public double SimpleInterest
        {
            get
            {
                return (_principleAmount * _duration * _rate());
            }
        }
    }
}
