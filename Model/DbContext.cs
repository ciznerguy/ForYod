using Microsoft.EntityFrameworkCore;
using ForYod.Model; // Update this namespace according to your project structure

namespace ForYod
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
<<<<<<< HEAD
        public DbSet<User> Users { get; set; } 

=======
>>>>>>> 230d044b6afcb745ab8d418295da8c43078c0935

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
