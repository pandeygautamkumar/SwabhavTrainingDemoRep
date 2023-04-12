using System;

namespace EngineeringColllegeApp.Model
{
    internal class Professor : Person
    {
        private double _monthlySalary;

        public Professor(int id, string address, string dateOfBirth,double monthlySalary) : base(id, address, dateOfBirth)
        {
            _monthlySalary = monthlySalary;
        }
        public double CalculateSalary()
        {
            double annualSalary = _monthlySalary * 12;
            if (annualSalary >= 500000)
            {
                return (annualSalary - (annualSalary * .18));
            }
            return annualSalary;
        }
    }
}
