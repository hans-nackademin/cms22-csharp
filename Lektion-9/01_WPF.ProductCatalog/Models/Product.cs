using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WPF.ProductCatalog.Models
{
    internal class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
