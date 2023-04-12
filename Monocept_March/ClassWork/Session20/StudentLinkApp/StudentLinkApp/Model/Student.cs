using System;

namespace StudentLinkApp.Model
{
    internal class Student
    {
        public string Name { get; set; }
        public Student Buddy { get; set; }
    }
}
