using System;

namespace GenericDictionaryApp.Model
{
    internal class Student
    {
        private int _standard;
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Standard {
            get
            {
                return _standard;
            }
            set
            {
                if(value>0 && value <= 12)
                {
                    _standard = value;
                }
            }
        }
        public override int GetHashCode()
        {
            return (this.Standard + "" + this.RollNo).GetHashCode();
        }
        public override bool Equals(object? second)
        {
            Student secondStudent = (Student) second;
            return (secondStudent.Standard==this.Standard) && (secondStudent.RollNo==this.RollNo);
        }
    }
}
