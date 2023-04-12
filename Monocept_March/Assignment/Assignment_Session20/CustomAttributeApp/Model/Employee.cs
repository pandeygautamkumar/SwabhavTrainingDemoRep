using System;

namespace CustomAttributeApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        public Employee(int id,string name)
        {
            _id = id;
            _name = name;
        }
        [GetMethodDetails("Employee ID.")]
        public int GetId()
        {
            return _id;
        }
        
        public string GetName()
        {
            return _name;
        }
    }
}
