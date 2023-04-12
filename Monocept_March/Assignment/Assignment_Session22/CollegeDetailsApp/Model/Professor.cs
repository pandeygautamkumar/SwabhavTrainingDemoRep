
namespace CollegeDetailsApp.Model
{
    internal class Professor
    {
        public string _name;
        public int _age;
        public string _designation;
        public Department _department;
        public Professor(string name, int age, string designation, Department department)
        {
            _name = name;
            _age = age;
            _designation = designation;
            _department = department;
        }

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public string Designation { get { return _designation; } }
        public Department Department { get { return _department; } }

    }
}
