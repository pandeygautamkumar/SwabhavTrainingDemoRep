
using AccountDalLib.Model;
using AccountDalLib.Repository;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BankConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountRepository _accountRepository = new AccountRepository();
            Console.WriteLine("Welcome to Simple Bank, please make your choice");
            Console.WriteLine("================================================");

            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string ch=Console.ReadLine();
                switch (ch)
                {
                     case "1":
                        Register(_accountRepository);
                        break;
                    case "2":
                        Login(_accountRepository);
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            } while (true);
        }

        static void Register(AccountRepository accountRepository)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your initial balance: ");
            decimal initialBalance;
            if (decimal.TryParse(Console.ReadLine(), out initialBalance))
            {
                // Hashing the password
                string hashedPassword = HashPassword(password);

                Account account = new Account()
                {
                    Name = name,
                    Password = hashedPassword,
                    Balance = initialBalance
                };

                accountRepository.AddAccount(account,initialBalance);

                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("Something went Wrong!!");
            }
        }
        static void Login(AccountRepository accountRepository)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            // Hash the entered password
            string hashedPassword = HashPassword(password);

            Account account = accountRepository.GetAccounts()
                .FirstOrDefault(a => a.Name == name && a.Password == hashedPassword);

            if (account != null)
            {
                Console.WriteLine("Login successful!");

                int choice;
                do
                {
                    Console.WriteLine("1. View Passbook");
                    Console.WriteLine("2. Do Transaction");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                ViewPassbook(account);
                                break;
                            case 2:
                                DoTransaction(account,accountRepository);
                                break;
                            case 3:
                                Console.WriteLine("Exiting...");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                    Console.WriteLine();
                } while (choice != 3);
            }
            else
            {
                Console.WriteLine("Enter Valid Choice!!");
            }
        }

        static void ViewPassbook(Account account)
        {
            Console.WriteLine("Passbook:");
            //decimal availableBalance = account.Balance;
            foreach (Transaction transaction in account.Transactions)
            {
                //if (transaction.Type == "D")
                //{
                //    availableBalance += transaction.Amount;
                //}
                //else if (transaction.Type == "W")
                //{
                //    availableBalance -= transaction.Amount;
                //}
                Console.WriteLine($"Transaction ID: {transaction.Id}, Name: {transaction.Name}, Amount: {transaction.Amount}, Available Balance: {transaction.AvailableBalance}, Type: {transaction.Type}, Date: {transaction.Date}");
            }
        }

        static void DoTransaction(Account account, AccountRepository accountRepository)
        {
            Console.Write("Enter the amount: ");
            decimal amount;
            if (decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Enter the transaction type (D for deposit, W for withdrawal): ");
                string type = Console.ReadLine().ToUpper();

                if (type == "D" || type == "W")
                {
                    decimal newBalance = (type == "D") ? account.Balance + amount : account.Balance - amount;

                    if (newBalance >= 0)
                    {
                        Transaction transaction = new Transaction()
                        {
                            Name = account.Name,
                            Amount = amount,
                            AvailableBalance = newBalance,
                            Type = type,
                            Date = DateTime.Now,
                            Account = account
                        };

                        account.Balance = newBalance;
                        account.Transactions.Add(transaction);

                        accountRepository.UpdateAccount(account,account.Id);

                        Console.WriteLine("Transaction successful!");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance!!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid transaction type!!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Amount!!");
            }
        }

        static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
