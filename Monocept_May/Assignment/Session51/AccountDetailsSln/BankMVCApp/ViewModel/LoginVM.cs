
using System.ComponentModel.DataAnnotations;

namespace BankMVCApp.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "UserName is Required Field. **")]
        [StringLength(20, ErrorMessage = "Maximum length of Name is only 5 Character.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "UserPassword is Required Field. **")]
        public string UserPassword { get; set;}
        public string Title { get; set; }
    }
}