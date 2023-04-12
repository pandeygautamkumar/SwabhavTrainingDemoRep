using System;

namespace EmployeePolymorphism.Model
{
    internal class Developer : Employee
    {
        private int _pa;
        private int _ota;

        public Developer(int id, string name, double basicSalary,int pa,int ota) : base(id, name, basicSalary)
        {
            _pa = pa;
            _ota = ota;
        }

        public override double CalculateAnnualSalary()
        {
            double totalSalary = _basicSalary + ((_basicSalary * _pa) / 100) + ((_basicSalary * _ota) / 100);
            return totalSalary;
        }
    }
}
