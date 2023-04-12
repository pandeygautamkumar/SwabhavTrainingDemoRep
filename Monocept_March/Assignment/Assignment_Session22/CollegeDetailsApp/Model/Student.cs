
namespace CollegeDetailsApp.Model
{
    internal class Student
    {
        private int _id;
        private string _name;
        private int _age;
        private string _subjectCode;
        private Department _department;

        public Student(int id, string name, int age, string subjectCode, Department department)
        {
            _id = id;
            _name = name;
            _age = age;
            _subjectCode = subjectCode;
            _department = department;
        }

        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public int Age { get { return _age; } }
        public string SubjectCode { get { return _subjectCode; } }
        public Department Department { get { return _department; } }
    }
}
