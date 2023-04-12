
namespace EmployeePolymorphismApp.Model
{
    internal class Developer : Employee
    {
        private double _porformanceAllowance;
        private double _overTimeAllowance;

        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _porformanceAllowance = _basicSalary * .50;
            _overTimeAllowance = _basicSalary * .40;
        }

        public override double CostToCompany
        {
            get
            {
                return (_basicSalary + _porformanceAllowance + _overTimeAllowance) * 12;
            }
        }
        public double PerformanceAllowance
        {
            get
            {
                return _porformanceAllowance;
            }
        }
        public double OverTimeAllowance
        {
            get
            {
                return _overTimeAllowance;
            }
        }
        public override string Role
        {
            get
            {
                return "Developer";
            }
        }
        public override string SalaryBreakUp
        {
            get
            {
                string formattedSalaryBreakup = $"Performance Allowance : {_porformanceAllowance}  OverTime Allownace is : {_overTimeAllowance}";
                return formattedSalaryBreakup;
            }
        }
    }
}
