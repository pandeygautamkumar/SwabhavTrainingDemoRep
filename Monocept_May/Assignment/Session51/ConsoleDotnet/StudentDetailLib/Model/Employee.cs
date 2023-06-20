namespace StudentDetailLib.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MobileNumber { get; set; }
        public string? Address { get; set;}
        public void DisplayStudent(Student student){
            Console.Write($"Student Id : {student.Id}   Student Name : {student.Name}    ");
            Console.WriteLine($"Student Mobile Number : {student.MobileNumber}    Address : {student.Address}");
        }
    }
}