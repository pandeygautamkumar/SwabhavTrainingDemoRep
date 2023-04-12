using System;


namespace EmployeePolymorphism.Model
{
    internal class QualityAnalyst : Employee
    {
        private int _perks;

        public QualityAnalyst(int id, string name, double basicSalary,int perks) : base(id, name, basicSalary)
        {
            _perks = perks;
        }

        public override double CalculateAnnualSalary()
        {
            double totalSalary = _basicSalary + ((_basicSalary * _perks) / 100); 
            return totalSalary;
        }
    }
}
