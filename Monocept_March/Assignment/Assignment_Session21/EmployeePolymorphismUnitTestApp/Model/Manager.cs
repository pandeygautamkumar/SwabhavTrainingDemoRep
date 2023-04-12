
namespace EmployeePolymorphismApp.Model
{
    internal class Manager : Employee
    {
        private double _houseRentAllowance;
        private double _travellingAllowance;
        private double _dearnessAllowance;
        public Manager(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _houseRentAllowance = _basicSalary * .60;
            _travellingAllowance = _basicSalary * .50;
            _dearnessAllowance = _basicSalary * .40;
        }

        public override double CostToCompany
        {
            get
            {
                return (_basicSalary+_houseRentAllowance+_travellingAllowance+_dearnessAllowance)*12;
            }
        }
        public double HouseRentAllowance
        {
            get
            {
                return _houseRentAllowance;
            }
        }
        public double TravellingAllowance
        {
            get
            {
                return _travellingAllowance;
            }
        }
        public double DearnessAllowance
        {
            get
            {
                return _dearnessAllowance;
            }
        }
        public override string Role
        {
            get
            {
                return "Manager";
            }
        }
        public override string SalaryBreakUp {
            get
            {
                string formattedSalaryBreakup = $"House Rent Allowance : {_houseRentAllowance}  Travelling Allowanace : {_travellingAllowance}  Dearness Allowance :  {_dearnessAllowance}";
                return formattedSalaryBreakup;
            }
        }
    }
}
