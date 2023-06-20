using System.ComponentModel.DataAnnotations;
namespace LoginMVCCoreApp.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="** ID is Required!!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "** Name is Required Field!!")]
        [StringLength(10, ErrorMessage = "Maximum length of Name is only 10 Character.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="** Password is Required!!")]
        public string? Password { get; set; }
        public string? Address { get; set; }
    }
}