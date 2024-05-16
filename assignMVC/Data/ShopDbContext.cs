using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data;

public class ShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("ProductInfo")
            .Property(e => e.ProductId)
            .HasColumnName("ProductNo");
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop5;User Id=dac5;Password=Dac5@1234;Encrypt=False");
    }
}