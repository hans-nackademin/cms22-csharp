using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Structs.Structs
{
    internal struct Customer
    {
        private string _name;

        public Customer()
        {

        }

        public Customer(string name, string email) : this()
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }


        public void GetCustomerRecord()
        {
            Console.WriteLine($"{Name} - {Email}");
        }
    }
}
