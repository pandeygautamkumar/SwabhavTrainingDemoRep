using System;

namespace EngineeringColllegeApp.Model
{
    internal class Student : Person
    {
        private string _branch;
        public Student(int id,string address,string dob,string branch): base(id,address,dob)
        {
            _branch = branch;
        }
        public string Branch
        {
            get
            {
                return _branch;
            }
            set
            {
                _branch = value;
            }
        }
    }
}
