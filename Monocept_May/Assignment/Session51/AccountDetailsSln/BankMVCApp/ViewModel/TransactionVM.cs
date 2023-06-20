

using AccountDalLib.Model;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BankMVCApp.ViewModel
{
    public class TransactionVM
    {
        public Account Account { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid amount!!")]
        public decimal Amount { get; set; }

        [Required]
        [RegularExpression("[DdWw]", ErrorMessage = "Please enter a valid transaction type (D or W)!!")]
        [Display(Name = "Transaction Type (D: Deposit, W: Withdraw)")]
        public string Type { get; set; }
    }
}