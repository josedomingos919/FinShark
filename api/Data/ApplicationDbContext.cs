using api.Models;
using Microsoft.EntityFrameworkCore;

namespace FinShark.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add your DbSet properties here
        // Example:
        // public DbSet<Stock> Stocks { get; set; }
        // public DbSet<Comment> Comments { get; set; }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configurations here
        }
    }
}