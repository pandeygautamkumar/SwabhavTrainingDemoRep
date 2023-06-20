using System.ComponentModel.DataAnnotations;

namespace EmployeeCoreCRUDApp.ViewModel
{
    public class EmployeeVM
    {
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public string? EmployeeName { get; set; }
        [Required]
        public decimal EmployeeSalary { get; set; }
    }
}
