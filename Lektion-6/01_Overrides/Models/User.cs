using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Overrides.Models
{
    internal class User
    {
        //var user = new User();
        public User()
        {

        }

        //var user = new User("Hans","Mattin-Lassei");
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //var user = new User("Hans","Mattin-Lassei", "hans@domain.com");
        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        //var user = new User(1, "Hans","Mattin-Lassei", "hans@domain.com");
        public User(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
