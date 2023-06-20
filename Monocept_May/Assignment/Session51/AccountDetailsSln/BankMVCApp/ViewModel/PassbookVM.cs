

using AccountDalLib.Model;
using System.Collections.Generic;

namespace BankMVCApp.ViewModel
{
    public class PassbookVM
    {
        public Account Account { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}