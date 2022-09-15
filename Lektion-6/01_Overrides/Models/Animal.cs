using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Overrides.Models
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }


        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret säger....");
        }

    }
}
