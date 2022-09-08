using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors.Models
{
    internal class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
            FirstName = "";
            LastName = "";
            Email = $"{FirstName.ToLower()}.{LastName.ToLower()}@domain.com";
        }

        public Customer(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = $"{FirstName.ToLower()}.{LastName.ToLower()}@domain.com";
        }

        public Customer(string firstName, string lastName, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Customer(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
