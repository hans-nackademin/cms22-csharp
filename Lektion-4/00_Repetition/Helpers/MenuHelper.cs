using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Helpers
{
    internal static class MenuHelper
    {
        private static List<Customer> customers = new List<Customer>();

        private static void ViewCustomerList(List<Customer> list) 
        {
            Console.Clear();
            Console.WriteLine("######## VIEW CUSTOMER LIST ########");
            foreach(var customer in list)
            {
                Console.WriteLine($"{customer.Id}. {customer.FirstName} {customer.LastName} ({customer.Email})");
            }

            Console.ReadKey();
        }
        private static Customer CreateNewCustomer() 
        {
            Console.Clear();
            Console.WriteLine("######## CREATE NEW CUSTOMER ########");

            var customer = new Customer();
                Console.Write("First Name: ");  customer.FirstName = Console.ReadLine();
                Console.Write("Last Name: ");   customer.LastName = Console.ReadLine();
                Console.Write("Email: ");       customer.Email = Console.ReadLine();

            return customer;
        }
        private static void RemoveCustomer(ref List<Customer> list) 
        {
            Console.Clear();
            Console.WriteLine("######## REMOVE CUSTOMER ########");
            Console.Write("Customer Id: ");
            var customerId = Console.ReadLine();

            list = list.Where(x => x.Id != int.Parse(customerId)).ToList();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("######## MENU ########");
            Console.WriteLine("1. View Customer List");
            Console.WriteLine("2. Create new Customer");
            Console.WriteLine("3. Remove Customer");
            Console.Write("Choose one option: ");
            
            var option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    ViewCustomerList(customers);
                    break;

                case "2":
                    customers.Add(CreateNewCustomer());
                    break;

                case "3":
                    RemoveCustomer(ref customers);
                    break;
            }

        }

    }
}
