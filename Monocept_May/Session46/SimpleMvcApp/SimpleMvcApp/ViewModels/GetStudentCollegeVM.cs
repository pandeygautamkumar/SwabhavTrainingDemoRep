

using SimpleMvcApp.Model;
using System.Collections.Generic;

namespace SimpleMvcApp.ViewModels
{
    public class GetStudentCollegeVM
    {
        public List<Student> Students { get; set; }
        public List<College> Colleges { get; set; } 
    }
}