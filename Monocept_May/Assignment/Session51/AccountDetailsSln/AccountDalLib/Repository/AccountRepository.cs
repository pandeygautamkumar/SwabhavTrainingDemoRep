
using AccountDalLib.EF;
using AccountDalLib.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.Linq;

namespace AccountDalLib.Repository
{
    public class AccountRepository
    {
        private readonly AccountDbContext _context;

        public AccountRepository()
        {
            _context = new AccountDbContext();
        }

        public void AddAccount(Account account,decimal initialBalance)
        {
            account.Transactions = new List<Transaction>(); // Initialize the Transactions collection
            _context.Accounts.Add(account);
            Transaction transaction = new Transaction()
            {
                Name = account.Name,
                Amount = initialBalance,
                AvailableBalance = initialBalance,
                Type = "D",
                Date = DateTime.Now,
                Account = account
            };
            account.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public List<Account> GetAccounts()
        {
            return _context.Accounts.Include(a => a.Transactions).ToList();
        }
        public void UpdateAccount(Account account,int id)
        {
            var data = _context.Accounts.Where(a => a.Id == id).FirstOrDefault();
            if (data != null)
            {
                data = account;
                _context.SaveChanges();
            }
        }
        public Account AccountById(string name)
        {
            var data = _context.Accounts.Where(a => a.Name== name).FirstOrDefault();
            if (data == null)
            {
                return null;
            }
            return data;
        }
    }
}
