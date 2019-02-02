using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Models.Database;
using System;

namespace Api.Models.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Test> Testing { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Test>();
        }
    }
}