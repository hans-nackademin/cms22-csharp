using _00_Repetition.ProductCatalog.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.ProductCatalog.Services
{
    internal interface IMenuManager
    {
        public void ShowMenuOptions();
    }

    internal class MenuManager : IMenuManager
    {
        private IFileManager _fileManager = new FileManager();
        private List<Product> _products = new();
        private string _filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.json";

        public void ShowMenuOptions()
        {
            Console.WriteLine("######### MENU #########");
            Console.WriteLine("1. Show Product Catalog");
            Console.WriteLine("2. Create new Product");
            Console.WriteLine("3. Settings");
            Console.WriteLine("");
            Console.Write("Choose one option (1-3): ");
            var option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    ShowProductCatalog();
                    break;

                case "2":
                    ShowCreateProduct();
                    break;

                case "3":
                    ShowSettings();
                    break;

                default:
                    Console.WriteLine("Invalid menu option selected.");
                    break;
            }
        }

        public void ShowProductCatalog()
        {
            try { _products = JsonConvert.DeserializeObject<List<Product>>(_fileManager.Read(_filePath)); }
            catch { }

            Console.Clear();
            Console.WriteLine("######### PRODUCT CATALOG #########");
            
            foreach(var product in _products)
                Console.WriteLine($"{product.Id} - {product.Name}");

            if(_products.Count > 0)
            {
                Console.WriteLine();
                Console.Write("View product details? (y/n): ");
                var option = Console.ReadLine();

                if (option?.ToLower() == "y")
                {
                    Console.Write("Enter Product Id: ");
                    var id = Console.ReadLine();
                    if (!string.IsNullOrEmpty(id))
                        ShowProductDetails(id);
                }
            }

        }

        public void ShowProductDetails(string id)
        {
            var product = _products.FirstOrDefault(x => x.Id == new Guid(id));

            Console.Clear();
            Console.WriteLine("######### PRODUCT DETAILS #########");
            Console.WriteLine($"ID: \t\t     {product?.Id}");
            Console.WriteLine($"NAME: \t\t   {product?.Name}");
            Console.WriteLine($"PRICE: \t\t  {product?.Price}");
            Console.WriteLine();
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete");
            Console.Write("Enter option: ");
            var option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    ShowUpdateProduct(product);
                    break;

                case "2":
                    DeleteProduct(product.Id);
                    break;

                default:
                    break;
            }
        }


        public void ShowCreateProduct()
        {
            var product = new Product();
            
            Console.Clear();
            Console.WriteLine("######### NEW PRODUCT #########");
            Console.Write("Enter Product Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            _products.Add(product);
            _fileManager.Save(_filePath, JsonConvert.SerializeObject(_products));
        }




        public void ShowUpdateProduct(Product product)
        {
            var index = 1;

            _products[index] = product;
            _fileManager.Save(_filePath, JsonConvert.SerializeObject(_products));
        }


        private void DeleteProduct(Guid id)
        {
            _products = _products.Where(x => x.Id != id).ToList();
            _fileManager.Save(_filePath, JsonConvert.SerializeObject(_products));
        }


        public void ShowSettings()
        {
            throw new NotImplementedException();
        }



    }
}
