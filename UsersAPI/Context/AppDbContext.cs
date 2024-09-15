using Microsoft.EntityFrameworkCore;
using UsersAPI.Models;

namespace UsersAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Usuario { get; set; }
    }
}
