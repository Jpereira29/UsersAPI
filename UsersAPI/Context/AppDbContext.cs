using Microsoft.EntityFrameworkCore;
using UsersAPI.Models;

namespace UsersAPI.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Usuario { get; set; }
    }
}
