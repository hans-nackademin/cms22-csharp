using _01_AccessModifiers.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers.Shared.Models
{
    public class Customer
    {
        public Customer()
        {
            var accessModifier = new AccessModifierHelper();

            accessModifier.PublicMethod();
            accessModifier.InternalMethod();
            accessModifier.ProtectedMethod();
            accessModifier.PrivateMethod();

        }
    }
}
