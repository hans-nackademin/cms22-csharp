using _03_FileManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FileManagement.Services
{
    internal class ProductService
    {
        private List<Product> _productCatalog;
        private FileService _fileService;

        public ProductService(string filePath)
        {
            _fileService = new FileService(filePath);
            _productCatalog = new List<Product>();
        }

        public void Init()
        {
            _productCatalog = Get().ToList();
        }

        public void Add(Product product)
        {
            _productCatalog.Add(product);
            _fileService.Save(_productCatalog);
        }

        public void Remove(Guid id)
        {
            _productCatalog = _productCatalog.Where(x => x.Id != id).ToList();
            _fileService.Save(_productCatalog);
        }

        public IEnumerable<Product> Get()
        {
            _productCatalog = _fileService.Read();
            return _productCatalog;
        }

    }
}
