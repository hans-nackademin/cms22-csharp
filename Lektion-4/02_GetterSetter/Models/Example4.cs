using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GetterSetter.Models
{
    internal class Example4
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }

        public string FullName { 
            get { return $"{FirstName} {LastName}"; } 
        }

        internal string DisplayName => $"{FirstName} {LastName}";


        internal string GetFullName()
        {
            return ""+ FirstName +" "+ LastName +"";
        }
    }
}
