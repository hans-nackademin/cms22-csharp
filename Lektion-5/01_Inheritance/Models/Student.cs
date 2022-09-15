using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance.Models
{
    internal class Student : User
    {
        public Student(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public Student(string firstName, string lastName, string email, string password, string classCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            ClassCode = classCode;
        }

        public string ClassCode { get; set; }

    }
}
