using _00_Repetition.ProductCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.ProductCatalog.Services
{
    internal static class MenuManager
    {
        public static Product CreateMenu()
        {
            var product = new Product();

            try
            {
                Console.Clear();
                Console.WriteLine("#######  CREATE PRODUCT #######");

                Console.Write("Product Name: ");
                product.Name = Console.ReadLine() ?? "";

                Console.Write("Product Price: ");
                product.Price = decimal.Parse(Console.ReadLine() ?? "0.0");
                
                return product;
            }
            catch 
            {
                Console.WriteLine("Invalid values added.");
                Console.ReadKey();
            }

            return null!;
        }

        public static void ViewListMenu(List<Product> list)
        {
            Console.Clear();
            Console.WriteLine("#######  VIEW PRODUCT CATALOG #######");

            foreach(var product in list)
            {
                Console.WriteLine($"{product.Id} - {product.Name} ({product.Price} SEK)");
            }

            Console.ReadKey();
        }

        public static void RemoveMenu(ref List<Product> list)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("#######  REMOVE PRODUCT #######");

                Console.Write("Product Id: ");
                var id = Guid.Parse(Console.ReadLine());

                list = list.Where(x => x.Id != id).ToList();
            }
            catch 
            {
                Console.WriteLine("Invalid Id selected.");
                Console.ReadKey();
            }

        }

        public static string OptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("####### PRODUCT CATALOG #######");
            Console.WriteLine("1. View Product Catalog");
            Console.WriteLine("2. Create new Product");
            Console.WriteLine("3. Remove Product");
            Console.Write("Choose one option (1-3): ");
            return Console.ReadLine() ?? "";
        }
    }
}
