using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Context
{
    public class FirstDbContext : DbContext
    {
        public FirstDbContext()
        {

        }
        public FirstDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PersonConfiguration().Configure(modelBuilder.Entity<Person>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost,1433;Initial Catalog=EFDatabase;User Id=sa;Password=Password123@;");
        }
    }
}

