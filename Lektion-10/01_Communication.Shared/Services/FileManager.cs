using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Communication.Shared.Services
{
    public interface IFileManager
    {
        public Task Save(string filePath, string content);
        public Task<string> Read(string filePath);
    }


    public class FileManager : IFileManager
    {
        public async Task<string> Read(string filePath)
        {
            using var sr = new StreamReader(filePath);
            return await sr.ReadToEndAsync();
        }

        public async Task Save(string filePath, string content)
        {
            using var sw = new StreamWriter(filePath);
            await sw.WriteLineAsync(content);
        }
    }
}
