namespace _01_ServiceLifetimes.Services
{
    public interface ITransientService
    {
        public string GetGuid();
    }

    public class TransientService : ITransientService
    {
        private Guid _guid;

        public TransientService()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
