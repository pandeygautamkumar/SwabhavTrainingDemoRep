using System.ComponentModel.DataAnnotations;

namespace LoginMVCCoreApp.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "UserName is Required Field. **")]
        [StringLength(10, ErrorMessage = "Maximum length of Name is only 10 Character.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "UserPassword is Required Field. **")]
        public string? Password { get; set;}
    }
}