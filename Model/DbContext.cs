using Microsoft.EntityFrameworkCore;
using ForYod.Model; // Update this namespace according to your project structure

namespace ForYod
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; } 


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
