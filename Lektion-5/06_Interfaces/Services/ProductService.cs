using _06_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfaces.Services
{

    internal interface IProductService
    {
        public void Create(Product product);
        public void Delete(int id);
        public IEnumerable<Product> GetAll();
        public Product Get(int id);
    }


    internal class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>();


        public void Create(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public void Delete(int id)
        {
            _products = _products.Where(x => x.Id != id).ToList();
        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id); 
        }

        public IEnumerable<Product> GetAll()
        {
            return _products.OrderBy(x => x.Id);
        }

        public Product Update(int id, Product product)
        {
            return null;
        }


    }
}
