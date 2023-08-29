using Microsoft.EntityFrameworkCore;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = true;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
