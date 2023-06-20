using SimpleMvcApp.Model;
using SimpleMvcApp.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
namespace SimpleMvcApp.Controllers
{
    public class StudentController : Controller 
    { 
        public ActionResult GetStudent()
        {
            Student student = new Student
            {
                Id=1,
                Name="Vikarant",
                Cgpa=9.56
            };
            return View(student);   
        }
        public ActionResult GetStudents()
        {
            Student student1 = new Student
            {
                Id = 1,
                Name = "Vikarant",
                Cgpa = 9.56
            };
            Student student2 = new Student
            {
                Id = 2,
                Name = "Manjunath",
                Cgpa = 8.78
            };
            Student student3 = new Student
            {
                Id = 3,
                Name = "Ekta",
                Cgpa = 9.00
            };
            List<Student> students = new List<Student>() { student1,student2,student3 };
            return View(students);
        }
        public ActionResult GetStudentCollege()
        {
            Student student1 = new Student
            {
                Id = 1,
                Name = "Vikarant",
                Cgpa = 9.56
            };
            Student student2 = new Student
            {
                Id = 2,
                Name = "Manjunath",
                Cgpa = 8.78
            };
            Student student3 = new Student
            {
                Id = 3,
                Name = "Ekta",
                Cgpa = 9.00
            };

            College c1 = new College
            {
                Id = 1,
                Name = "KC"
            };
            College c2 = new College
            {
                Id = 2,
                Name = "Kalinga"
            };
            List<Student> students = new List<Student>() { student1, student2, student3 };
            List<College>colleges = new List<College>() { c1,c2 };
            GetStudentCollegeVM getStudentCollegeVM = new GetStudentCollegeVM
            {
                Students= students,
                Colleges = colleges
            };
            return View(getStudentCollegeVM);
        }
    }
}