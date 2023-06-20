
using System.ComponentModel.DataAnnotations;

namespace ContactMVCAppV2.ViewModel
{
    public class AddVM
    {
        [Required(ErrorMessage ="*Id is Required Field..")]
        public int Id { get; set; }
        [Required(ErrorMessage = "*Name is Required Field..")]
        [MaxLength(15,ErrorMessage ="*max Length of Name will be 15 Character..")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*Mobile Number is Required Field..")]
        [MaxLength(10, ErrorMessage = "*max Length of Mobile Number will be 10 Character..")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "*Address is Required Field..")]
        [MaxLength(50, ErrorMessage = "*max Length of Address will be 50 Character..")]
        public string Address { get; set; }
    }
}