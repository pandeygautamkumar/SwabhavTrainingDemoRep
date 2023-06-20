using System.ComponentModel.DataAnnotations;

namespace EmployeeCoreCRUDApp.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="**Name is Required Field.!!")]
        [MaxLength(20,ErrorMessage ="Name Will be Max of 20 Character.!!")]
        public String? Name { get; set; }
        [Required(ErrorMessage ="**Password is Required FIeld.!!")]
        public String? Password { get; set; }    
        public string? ReturnUrl { get; set; }
        public bool RememberLogin { get; set; }
    }
}
