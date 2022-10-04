using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DependencyInjection.WPF.Services
{
    public interface IFileManager
    {
        public Task SaveAsync(string filePath, string content);
        public Task<string> ReadAsync(string filePath);
    }

    public class FileManager : IFileManager
    {
        public async Task<string> ReadAsync(string filePath)
        {
            using var sr = new StreamReader(filePath);
            return await sr.ReadToEndAsync();
        }

        public async Task SaveAsync(string filePath, string content)
        {
            var text = await ReadAsync(filePath);
            text += content;

            using var sw = new StreamWriter(filePath);
            await sw.WriteLineAsync(text);
        }
    }
}
