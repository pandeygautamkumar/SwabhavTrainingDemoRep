using System;

namespace EngineeringColllegeApp.Model
{
    internal class Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;

        public Person(int id, string address, string dateOfBirth)
        {
            _id = id;
            _address = address;
            _dateOfBirth = dateOfBirth;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
    }
}
