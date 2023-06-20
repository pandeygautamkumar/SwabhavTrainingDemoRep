
using System;

namespace AccountDalLib.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal AvailableBalance { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }
    }
}
