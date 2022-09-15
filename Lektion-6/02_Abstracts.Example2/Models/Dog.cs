using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstracts.Example2.Models
{
    internal class Dog : Animal
    {
        public string Name { get; set; }

        public void Bark()
        {
            Console.WriteLine("wow...wow");
        }

    }
}
