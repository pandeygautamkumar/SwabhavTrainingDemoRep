using StudentDetailLib.Model;
namespace StudentConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students=new List<Student>();
            students.Add(new Student{
                Id=1,Name="Gautam",MobileNumber="94351632364",Address="Varanasi"
            });
            students.Add(new Student{
                Id=2,Name="Manjunath",MobileNumber="94351632364",Address="HYD"
            });
            students.Add(new Student{
                Id=3,Name="Vikrant",MobileNumber="94351632364",Address="HYD"
            });

            Console.WriteLine("Student Details are : ");
            Console.WriteLine("=======================================");
            foreach(var student in students){
                student.DisplayStudent(student);
            }
        }
    }
}



