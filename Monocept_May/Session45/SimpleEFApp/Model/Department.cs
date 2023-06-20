
using System.Collections.Generic;

namespace SimpleEFApp.Model
{
    public class Department
    {
        public Department()
        {
            Employees=new List<Employee>();
        }
        public int Id { get; set; } 
        public string DName { get; set; }
        public List<Employee> Employees { get; set;}
    }
}
