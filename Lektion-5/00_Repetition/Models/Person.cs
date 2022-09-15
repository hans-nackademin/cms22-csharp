using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Models
{
    internal class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;

            Email = email.Trim().ToLower();

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";

    }
}


