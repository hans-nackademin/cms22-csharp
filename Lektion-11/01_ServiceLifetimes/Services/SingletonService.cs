namespace _01_ServiceLifetimes.Services
{
    public interface ISingletonService
    {
        public string GetGuid();
    }

    public class SingletonService : ISingletonService
    {
        private Guid _guid;

        public SingletonService()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
