using System;

namespace EmployeeApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;
        public Employee(int id,string name,double salary) {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Id is {_id} Name is : {_name} Salary is : {_salary} {base.ToString()}";
        }
        public override bool Equals(object obj)
        {
            Employee employee = (Employee)obj;
            return (employee._id == this._id && employee._name==this._name && employee._salary==this._salary); 
        }
    }
}
