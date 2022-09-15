using _02_Abstracts.Example1.Data;
using _02_Abstracts.Example1.Models;

namespace _02_Abstracts.Example1.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

    }
}
