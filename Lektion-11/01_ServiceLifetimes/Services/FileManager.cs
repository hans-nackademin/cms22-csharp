namespace _01_ServiceLifetimes.Services
{
    public interface IFileManager
    {
        public void Save(string filePath, string content);
        public string Read(string filePath);
    }

    public class FileManager : IFileManager
    {
        public string Read(string filePath)
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }

        public void Save(string filePath, string content)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
        }
    }
}
