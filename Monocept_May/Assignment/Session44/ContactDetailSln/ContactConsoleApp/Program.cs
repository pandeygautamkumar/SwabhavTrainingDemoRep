
using ContactDALLib.Model;
using ContactDALLib.Repository;
using System;
using System.Collections.Generic;

namespace ContactConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactRepository repository = new ContactRepository();
            while (true)
            {
                Console.WriteLine("1. Add to Contact Database");
                Console.WriteLine("2. Display All Details of Contact Database");
                Console.WriteLine("3. Exit");
                Console.WriteLine("=====================================================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContactToDB(repository);
                        break;
                    case "2":
                        DisplayDB(repository);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void AddContactToDB(ContactRepository contactRepository)
        {
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Mobile Number: ");
            string mobileNumber = Console.ReadLine();

            Console.Write("Enter Address : ");
            string address=Console.ReadLine();

            Contact contact = new Contact
            {
                Id = id,
                Name = name,
                MobileNumber = mobileNumber,
                Address = address
            };

            contactRepository.AddContact(contact);
            Console.WriteLine("Data added successfully.");
        }

        static void DisplayDB(ContactRepository contactRepository)
        {
            List<Contact> contacts = contactRepository.GetContact();

            if (contacts.Count == 0)
            {
                Console.WriteLine("DB is empty.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Mobile Number: {contact.MobileNumber},Address: {contact.Address}");
                }
            }
        }
    }
}
