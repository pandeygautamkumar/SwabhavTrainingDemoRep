using AccountDalLib.Model;
using AccountDalLib.Repository;
using BankMVCApp.Common;
using BankMVCApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BankMVCApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountRepository _accountRepository;
        public AccountController()
        {
            _accountRepository = new AccountRepository();   
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Account account = new Account();
            account = _accountRepository.AccountById(vm.Name);
            if (account == null)
            {
                ModelState.AddModelError("", "User Details Not Found!!");
                return RedirectToAction("Login");
            }
            if ((account.Name != vm.Name) || (account.Password != PasswordHasher.HashPassword(vm.UserPassword)))
            {
                ModelState.AddModelError("", "Invalid Username or Password.");
                return RedirectToAction("Login");
            }
            Session["username"] = vm.Name;
            FormsAuthentication.SetAuthCookie(vm.Name, false);
            return RedirectToAction("Passbook");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Session["username"] = vm.Name;
            Account account = new Account
            {
                Id = vm.Id,
                Name = vm.Name,
                Password = PasswordHasher.HashPassword(vm.Password),
                Balance = vm.Balance
            };
            _accountRepository.AddAccount(account, vm.Balance);
            FormsAuthentication.SetAuthCookie(vm.Name, false);
            return RedirectToAction("Passbook");
        }
        public ActionResult Passbook()
        {
            string username = (string)Session["username"];
            Account account = _accountRepository.GetAccounts().FirstOrDefault(a => a.Name == username);
            if (account != null)
            {
                PassbookVM passbookVM = new PassbookVM()
                {
                    Account = account,
                    Transactions = account.Transactions
                };
                return View(passbookVM);
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult DoTransaction()
        {
            string username = (string)Session["username"];
            Account account = _accountRepository.GetAccounts().FirstOrDefault(a => a.Name ==username);

            if (account != null)
            {
                TransactionVM transactionVM = new TransactionVM()
                {
                    Account = account
                };

                return View(transactionVM);
            }

            return RedirectToAction("Passbook");
        }

        [HttpPost]
        public ActionResult DoTransaction(TransactionVM transactionVM)
        {
            if (ModelState.IsValid)
            {
                string username = (string)Session["username"];
                Account account =_accountRepository.GetAccounts().FirstOrDefault(a => a.Name ==username);
                if (account != null)
                {
                    decimal amount = transactionVM.Amount;
                    string type = transactionVM.Type.ToUpper();

                    if (type == "D")
                    {
                        account.Balance += amount;
                    }
                    else if (type == "W")
                    {
                        if (account.Balance >= amount)
                        {
                            account.Balance -= amount;
                        }
                        else
                        {
                            ModelState.AddModelError("", "Insufficient Balance!!");
                            return View(transactionVM);
                        }
                    }

                    Transaction transaction = new Transaction()
                    {
                        Name = account.Name,
                        Amount = amount,
                        AvailableBalance = account.Balance,
                        Type = type,
                        Date = DateTime.Now,
                        Account = account
                    };

                    account.Transactions.Add(transaction);

                    _accountRepository.UpdateAccount(account,account.Id);

                    return RedirectToAction("Passbook");
                }
            }

            ModelState.AddModelError("", "Invalid transaction details.");
            return View(transactionVM);
        }
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}