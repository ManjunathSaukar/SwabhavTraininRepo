using ContactDALLib.Model;
using ContactDALLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=ContactDB;Integrated Security=True";
            ContactRepository contactRepository = new ContactRepository(connectionString);

            while (true)
            {
                Console.WriteLine("1. Add to DB");
                Console.WriteLine("2. Display DB");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContactToDB(contactRepository);
                        break;
                    case "2":
                        DisplayDB(contactRepository);
                        break;
                    case "3":
                        return;
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

            Contact contact = new Contact
            {
                Id = id,
                Name = name,
                MobileNumber = mobileNumber
            };

            contactRepository.AddContact(contact);
            Console.WriteLine("Data added successfully.");
        }

        static void DisplayDB(ContactRepository contactRepository)
        {
            List<Contact> contacts = contactRepository.GetContacts();

            if (contacts.Count == 0)
            {
                Console.WriteLine("DB is empty.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Mobile Number: {contact.MobileNumber}");
                }
            }
        }
    }
}
