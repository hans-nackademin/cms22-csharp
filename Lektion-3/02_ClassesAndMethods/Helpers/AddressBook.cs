using _02_ClassesAndMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesAndMethods.Helpers
{
    internal static class AddressBook
    {
        private static List<Contact> _contacts = new List<Contact>();
    

        // Methods
        public static void ViewContactsMenu()
        {
            Console.Clear();
            Console.WriteLine("##### CONTACTS - ADDRESS BOOK #####");
            
            foreach (var contact in _contacts)
                Console.WriteLine($"{contact.Name}, {contact.StreetName} {contact.PostalCode.Replace(" ", "")} {contact.City}");
        }

        public static void NewContactMenu()
        {
            Console.Clear();
            Console.WriteLine("##### NEW CONTACT - ADDRESS BOOK #####");

            Contact contact = new Contact();

            Console.Write("Name: ");
            contact.Name = Console.ReadLine();

            Console.Write("Street Name: ");
            contact.StreetName = Console.ReadLine();

            Console.Write("Postal Code: ");
            contact.PostalCode = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            _contacts.Add(contact);
        }

        public static string OptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("##### ADDRESS BOOK #####");
            Console.WriteLine("1. View Address book");
            Console.WriteLine("2. Add new Contact");
            Console.WriteLine("Q. Exit Application");
            Console.Write("Choose one option: ");

            return Console.ReadLine();
        }

        public static void Run()
        {

        }
    }
}
