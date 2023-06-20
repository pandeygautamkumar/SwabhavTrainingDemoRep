
using AccountDalLib.Model;
using System.Collections.Generic;

namespace BankMVCApp.ViewModel
{
    public class RegisterVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    }
}