using System;

namespace EmployeePolymorphism.Model
{
    internal class Manager : Employee
    {
        private int _hra;
        private int _ta;
        private int _da;
        public Manager(int id, string name, double basicSalary,int hra,int ta,int da) : base(id, name, basicSalary)
        {
            _hra = hra;
            _ta = ta;
            _da = da;
        }

        public override double CalculateAnnualSalary()
        {
            double totalSalary = _basicSalary + ((_basicSalary * _hra) / 100) + ((_basicSalary * _ta) / 100) * 12 + ((_basicSalary * _da) / 100);
            return totalSalary;
        }
    }
}
