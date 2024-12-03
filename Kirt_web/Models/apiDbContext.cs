using Microsoft.EntityFrameworkCore;
using Kirt_web.Models;

namespace Kirt_web.Models
{
    public class apiDbContext : DbContext
    {
        public apiDbContext(DbContextOptions<apiDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Subcategory>().ToTable("Subcategories");
            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<Product>()
                .Property(p => p.StockCount)
                .IsRequired(); // Gerekirse, bu alanı zorunlu hale getirir
        }





    }
}
