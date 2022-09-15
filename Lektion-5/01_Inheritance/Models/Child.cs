using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance.Models
{
    internal class Child : Parent
    {
        public Child()
        {
            ParentId = 1;
            GrandParentId = 1;
        }

        public int ChildId { get; set; }
    }
}
