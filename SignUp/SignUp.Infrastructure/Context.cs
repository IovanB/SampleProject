using Microsoft.EntityFrameworkCore;
using SignUp.Domain.Entities;

namespace SignUp.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Employee> Emplooyees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryProvider");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
