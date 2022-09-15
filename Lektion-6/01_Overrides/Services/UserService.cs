using _01_Overrides.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Overrides.Services
{
    internal interface IUserService
    {
        public IEnumerable<User> Read();
        public User Read(int id);
        public User Read(string email);

    }

    internal class UserService : IUserService
    {
        public IEnumerable<User> Read()
        {
            throw new NotImplementedException();
        }

        public User Read(int id)
        {
            throw new NotImplementedException();
        }

        public User Read(string email)
        {
            throw new NotImplementedException();
        }
    }
}
