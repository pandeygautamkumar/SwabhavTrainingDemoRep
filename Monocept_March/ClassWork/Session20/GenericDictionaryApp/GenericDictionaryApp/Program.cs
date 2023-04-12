using GenericDictionaryApp.Model;

namespace GenericDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  CaseStudy1();
           CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Student s1 = new Student { Standard = 10, RollNo = 1, Name = "Ravi" };
            Student s2 = new Student { Standard = 10, RollNo = 1, Name = "Ravi" };
            Student s3 = new Student { Standard = 10, RollNo = 10, Name = "Ravi" };
            var students = new Dictionary<Student, Student>();
            students.Add(s1, s2);
           // students.Add(s2, s3);
            students.Add(s3, s3);
            Console.WriteLine(students.Count);
        }

        private static void CaseStudy1()
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();

            stateCodes.Add("MH", "Maharastra");
            stateCodes.Add("KA", "Karnataka");
            stateCodes.Add("KL", "Kerala");

            if (stateCodes.ContainsKey("KL"))
            {
                stateCodes.Remove("KL");
                stateCodes.Add("KL", "New Kerala");
            }
            Console.WriteLine(stateCodes.Count);

            foreach (var row in stateCodes)
            {
                Console.WriteLine("Key is {0} -- Value is {1} ", row.Key, row.Value);
            }

            stateCodes["MH"] = "New Maharastra";
            Console.WriteLine(stateCodes["MH"]);
        }
    }
}