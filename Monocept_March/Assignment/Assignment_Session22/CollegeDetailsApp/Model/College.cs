using System;

namespace CollegeDetailsApp.Model
{
    internal class College
    {
        private string _collegeName;
        private List<Student> _students;
        private List<Professor> _professors;
        private List<Department> _departments;
        public College(string collegeName)
        {
            _collegeName = collegeName;
            _departments = new List<Department>();
            _students = new List<Student>();
            _professors = new List<Professor>();
        }
        public string College_Name { get { return _collegeName; } }
        public List<Student> Students { get { return _students; } }
        public List<Professor> Professors { get { return _professors; } }
        public List<Department> Departments { get { return _departments; } }


        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }

}
