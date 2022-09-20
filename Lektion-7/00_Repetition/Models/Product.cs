using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _00_Repetition.Models
{
    internal class Product
    {
        public Product()
        {

        }

        public Product(Guid id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!s
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
