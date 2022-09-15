using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Interfaces
{
    internal interface IAuth
    {
        public void SignIn(string email, string password);
        public void SignUp();
        public void SignOut();
    }
}
