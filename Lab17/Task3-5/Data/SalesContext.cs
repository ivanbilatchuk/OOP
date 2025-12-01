using Microsoft.EntityFrameworkCore;
using Task3.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Task3_5.Data;

public class SalesContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Sale> Sales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=SalesDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(p => p.Name).HasMaxLength(50).IsUnicode(true);
            entity.Property(p => p.Description).HasMaxLength(250).HasDefaultValue("No description");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(c => c.Name).HasMaxLength(100).IsUnicode(true);
            entity.Property(c => c.Email).HasMaxLength(80).IsUnicode(false);
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.Property(s => s.Name).HasMaxLength(80).IsUnicode(true);
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.Property(s => s.Date).HasDefaultValueSql("GETDATE()");
        });
    }
}