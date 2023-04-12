using StudentLinkApp.Model;
using System.ComponentModel;

namespace StudentLinkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student manjunath = new Student { Name= "Manjunath"};
            Student ekta = new Student { Name = "Ekta" };
            Student ravi = new Student { Name = "Ravi" };
            Student shubh = new Student { Name = "Shubh" };

            manjunath.Buddy = ekta;
            ekta.Buddy = shubh;
            shubh.Buddy =ravi;
            ravi.Buddy = null;

           //PrintDetails(manjunath);
          PrintRecursive(manjunath);
        }
        private static void PrintDetails(Student student)
        {
            while (student!= null)
            {
                Console.Write(student.Name+" Buddy is : ");
                student=student.Buddy;
                if (student != null)
                    Console.WriteLine(student.Name);
            }
        }

        private static void PrintRecursive(Student student)
        {
            if (student == null)
                return;
            Console.Write(student.Name + " Buddy is : ");
            student = student.Buddy;
            if (student != null)
                Console.WriteLine(student.Name);
            PrintRecursive(student);
        }
    }
}