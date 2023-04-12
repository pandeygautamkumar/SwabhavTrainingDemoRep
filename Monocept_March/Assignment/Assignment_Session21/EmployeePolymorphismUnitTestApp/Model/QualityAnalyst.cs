
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphism.Model
{
    internal class QualityAnalyst :Employee
    {
        private double _perks;

        public QualityAnalyst(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _perks =_basicSalary*.40;
        }

        public override double CostToCompany
        {
            get
            {
                return (_basicSalary + _perks) * 12;
            }
        }
        public double Perk
        {
            get
            {
                return _perks;
            }
        }
        public override string Role
        {
            get
            {
                return "QualityAnalyst";
            }
        }
        public override string SalaryBreakUp
        {
            get
            {
                string formattedSalaryBreakup = $"Perks is : {_perks}";
                return formattedSalaryBreakup;
            }
        }
    }
}
