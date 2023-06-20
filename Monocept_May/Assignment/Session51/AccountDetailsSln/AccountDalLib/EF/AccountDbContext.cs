
using AccountDalLib.Model;
using System.Data.Entity;

namespace AccountDalLib.EF
{
    public class AccountDbContext :DbContext
    {
        public AccountDbContext() : base("AccountDbContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
