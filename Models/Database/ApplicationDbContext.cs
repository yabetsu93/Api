using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Models.Database;

namespace Api.Models.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Test> Testing {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Test>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(MySqlConfig.ConnectionString);
            }
        }
    }
} 