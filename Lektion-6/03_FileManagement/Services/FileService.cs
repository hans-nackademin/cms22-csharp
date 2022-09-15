using _03_FileManagement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FileManagement.Services
{
    internal class FileService
    {
        private string _filePath;

        public FileService(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(List<Product> list)
        {
            using var sw = new StreamWriter(_filePath);
            sw.WriteLine(JsonConvert.SerializeObject(list));
        }


        public List<Product> Read()
        {
            var list = new List<Product>();

            try
            {
                using var sr = new StreamReader(_filePath);
                list = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
            catch { }

            return list;
        }


    }
}
