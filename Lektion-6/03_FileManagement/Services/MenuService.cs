using _03_FileManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FileManagement.Services
{
    internal interface IMenu
    {
        public void Create();
        public void List();
        public void Details();
        public void Remove();
        public void Init();
    }


    internal class MenuService : IMenu
    {
        private ProductService _productService;

        public MenuService(string filePath)
        {
            _productService = new ProductService(filePath);
        }

        public void Init()
        {
            _productService.Init();
        }


        public void Create()
        {
            var product = new Product();

            Console.Clear();
            Console.WriteLine("CREATE NEW PRODUCT");
            
            Console.Write("Product Name: ");
            product.Name = Console.ReadLine();
            
            Console.Write("Product Description: ");
            product.Description = Console.ReadLine();
            
            Console.Write("Product Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            _productService.Add(product);
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
