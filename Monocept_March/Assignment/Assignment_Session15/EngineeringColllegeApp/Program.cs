using EngineeringColllegeApp.Model;
using System;

namespace EngineeringColllegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStudentDetails(new Student(101, "Varanasi", "22-03-1999", "CSE"));
            PrintProfessorDetails(new Professor(102,"Delhi","23-04-1998",34500));
        }
        private static void PrintStudentDetails(Student student)
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Id of Student : "+student.Id);
            Console.WriteLine("Address of Student : "+student.Address); 
            Console.WriteLine("Date of Birth of Professor: "+student.DateOfBirth);
            Console.WriteLine("Branch of Student : "+student.Branch);
            Console.WriteLine("---------------------------------------------------");
        }
        private static void PrintProfessorDetails(Professor professor)
        {
            Console.WriteLine("Professor Details : ");
            Console.WriteLine("Id of Professor : " + professor.Id);
            Console.WriteLine("Address of Professor : " + professor.Address);
            Console.WriteLine("Date of Birth of Professor : " + professor.DateOfBirth);
            Console.WriteLine("Annual Salary of Professor is : " +professor.CalculateSalary());
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
