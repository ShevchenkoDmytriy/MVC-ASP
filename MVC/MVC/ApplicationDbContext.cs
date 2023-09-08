using Microsoft.EntityFrameworkCore;
using MVC.Model;

namespace MVC
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users { Id=1,Name="qwqg",Age=23},
                                new Users { Id = 2, Name = "qwqg", Age = 23 },
                                                new Users { Id = 3, Name = "qwqg", Age = 23 }
                );
        }
    }

}
