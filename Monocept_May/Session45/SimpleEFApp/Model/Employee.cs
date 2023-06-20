

namespace SimpleEFApp.Model
{
    public class Employee
    {
        public int Id { get; set; } 
        public string EName { get; set; }   
        public string Address { get; set; }
        public Department Department { get; set; }
    }
}
