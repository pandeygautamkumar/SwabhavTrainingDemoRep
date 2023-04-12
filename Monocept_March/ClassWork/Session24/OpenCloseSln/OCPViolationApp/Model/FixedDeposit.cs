
namespace OCPViolationApp.Model
{
    internal class FixedDeposit
    {
        private int _accNo;
        private string _name;
        private double _principleAmount;
        private int _duration;
        private FestivalTypes _festivalType;
        public FixedDeposit(int accNo,string name,double principleAmount,int duration,FestivalTypes festivalType)
        {
            _accNo = accNo;
            _name = name;
            _principleAmount = principleAmount;
            _duration = duration;
            _festivalType = festivalType;
        }

        public double CalculateRate()
        {
            if (_festivalType == FestivalTypes.DIWALI)
                return .09;
            else if (_festivalType == FestivalTypes.NEW_YEAR)
                return .08;
            else
                return .07;
        }

        public double SimpleInterest
        {
            get
            {
                return (_principleAmount * _duration * CalculateRate());
            }
        }
    }
}
