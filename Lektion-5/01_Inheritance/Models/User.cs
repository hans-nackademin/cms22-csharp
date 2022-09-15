using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance.Models
{
    internal class User
    {
        protected int Id { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Email { get; set; }
        protected string Password { get; set; }
        protected string UserRole { get; set; }
    }
}
