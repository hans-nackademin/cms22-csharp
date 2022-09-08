using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02_GetterSetter.Models
{
    internal class Example3
    {
        public byte[] Password { get; private set; }
        public byte[] Salt { get; private set; }


        public void CreateSecurePassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                Salt = hmac.Key;
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
