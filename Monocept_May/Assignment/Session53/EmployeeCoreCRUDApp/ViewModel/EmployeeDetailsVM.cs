using EmployeeCoreCRUDApp.Models;

namespace EmployeeCoreCRUDApp.ViewModel
{
    public class EmployeeDetailsVM
    {
        public int EmployeeCount { get; set; }
        public List<Employee>? Employees { get; set; }   
    }
}
