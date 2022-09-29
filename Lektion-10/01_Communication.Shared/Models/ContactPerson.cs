using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Communication.Shared.Models
{
    public class ContactPerson
    {
        public ContactPerson()
        {

        }

        public ContactPerson(string firstName, string lastName, string streetName, string postalCode, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetName = streetName;
            PostalCode = postalCode;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
