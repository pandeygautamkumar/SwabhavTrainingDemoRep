using CollegeDetailsApp.Model;

namespace CollegeDetailsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college = new College("NIT Jamshedpur");

            Department mca = new Department(101,"MCA","MCA");
            Department cse = new Department(102, "Computer Science", "CSE");
            Department ce = new Department(103, "CIVIL", "CE");
            Department me = new Department(104, "Machanical", "ME");
            Department ee = new Department(105, "Electrical and Electronics", "EE");

            college.AddDepartment(mca);
            college.AddDepartment(cse);
            college.AddDepartment(ce);
            college.AddDepartment(me);
            college.AddDepartment(ee);

            college.AddStudent(new Student(1001, "Gautam", 24, "CA1011", mca));
            college.AddStudent(new Student(1002, "Vikrant", 25, "CS1011", cse));
            college.AddStudent(new Student(1003, "Ravi", 24, "CA1013", mca));
            college.AddStudent(new Student(1004, "Subh", 25, "EE1011", ee));
            college.AddStudent(new Student(1005, "Anikant", 24, "ME1011", me));

            college.AddProfessor(new Professor("Dr. Chandrashekhar Azad",45,"Associate Professor",cse));
            college.AddProfessor(new Professor("Dr. Alekha Mishra", 40, "Professor", mca));

            PrintDetails(college);
        }

        private static void PrintDetails(College college)
        {
            Console.WriteLine($"College Name is : {college.College_Name}");
            Console.WriteLine();

            Console.Write($"No of Department Available : {college.Departments.Count} .");
            Console.WriteLine(" These Are : ");
            foreach(var depratment in college.Departments)
            {
                Console.WriteLine($"Department Id is : {depratment.DepartmentCode}  |    Department Name is : {depratment.DepartmentName}  |  Department Code is : {depratment.DepartmentCode}");
            }

            Console.WriteLine();
            Console.Write($"No of Student Available in College: {college.Students.Count} .");
            Console.WriteLine(" These Are : ");
            foreach (var student in college.Students)
            {
                Console.Write($"Student Id is : {student.Id}   |  Student Name is : {student.Name}  |  Student Age is : {student.Age}");
                Console.WriteLine($"|     Student Subject Code is : {student.SubjectCode}  |   Student Department is : {student.Department.DepartmentName}");
            }

            Console.WriteLine();
            Console.Write($"No of Professor Available in College: {college.Professors.Count}  .");
            Console.WriteLine("These Are : ");
            foreach (var professor in college.Professors)
            {
                Console.Write($"Professor Name is : {professor.Name}  |  Professor Age is : {professor.Age}    |");
                Console.WriteLine($"    Professor Designation is : {professor.Designation}  |   Professor Department is :{professor.Department.DepartmentName}");
            }
        }
    }
}