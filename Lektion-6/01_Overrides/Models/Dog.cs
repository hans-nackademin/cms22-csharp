using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Overrides.Models
{
    internal class Dog : Animal
    {

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Hunden säger...wow wow");
        }
    }
}
