
namespace EmployeePolymorphismApp.Model
{
    internal abstract class Employee
    {
        private int _id;
        private string _name;
        protected double _basicSalary;

        public Employee(int id, string name, double basicSalary)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
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
        public double BasicSalary{ get { return _basicSalary; } }
        public abstract double CostToCompany { get; }
        public abstract string Role { get; }
        public abstract string SalaryBreakUp { get; }
    }
}
