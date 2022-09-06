using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_1.Models
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string Address => $"{StreetName} {PostalCode} {City}";
    }
}
