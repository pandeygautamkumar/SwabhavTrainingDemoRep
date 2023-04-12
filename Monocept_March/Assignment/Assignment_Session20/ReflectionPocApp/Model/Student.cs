using System;

namespace ReflectionPocApp.Model
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public Student()
        {
            RollNo = 0;
            Name = "";
        }
        public Student(int rollNo,string name)
        {
            RollNo = rollNo;
            Name = name;
        }
        public void PrintStudentData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }
}
