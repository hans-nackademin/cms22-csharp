using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers.Shared.Helpers
{
    public class AccessModifierHelper
    {

        public AccessModifierHelper()
        {
            PublicMethod();
            InternalMethod();
            ProtectedMethod();
            PrivateMethod();
        }



        public void PublicMethod() { }
        internal void InternalMethod() { }
        protected void ProtectedMethod() { }
        private void PrivateMethod() { }

    }
}
