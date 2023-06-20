using System.ComponentModel.DataAnnotations;

namespace EmployeeCoreCRUDApp.ViewModel
{
    public class EmployeeEditVM
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string? EmployeeName { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
