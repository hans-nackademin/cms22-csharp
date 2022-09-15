using _02_Abstracts.Example1.Models;
using Microsoft.EntityFrameworkCore;

namespace _02_Abstracts.Example1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
