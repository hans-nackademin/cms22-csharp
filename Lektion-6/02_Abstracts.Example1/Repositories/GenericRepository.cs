using _02_Abstracts.Example1.Data;

namespace _02_Abstracts.Example1.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        private readonly DataContext _context;

        protected GenericRepository(DataContext context)
        {
            _context = context;
        }


        // public void Create(UserEntity entity)
        // public void Create(CustomerEntity entity)
        // public void Create(ProductEntity entity)
        public virtual void Create(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public virtual List<T> Read()
        {
            return _context.Set<T>().ToList();
        }

    }
}
