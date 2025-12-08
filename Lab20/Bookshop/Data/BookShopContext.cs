using Bookshop.Models;
using Microsoft.EntityFrameworkCore;
namespace Bookshop.Data;

public class BookShopContext : DbContext
    {
        public BookShopContext() { }

        public BookShopContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BooksCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=BookShop;Integrated Security=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorId);
                entity.Property(e => e.FirstName).HasMaxLength(50).IsUnicode(true).IsRequired(false);
                entity.Property(e => e.LastName).HasMaxLength(50).IsUnicode(true).IsRequired(true);
            });
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookId);
                entity.Property(e => e.Title).HasMaxLength(50).IsUnicode(true).IsRequired(true);
                entity.Property(e => e.Description).HasMaxLength(1000).IsUnicode(true).IsRequired(true);
                entity.Property(e => e.ReleaseDate).IsRequired(false);
                entity.Property(e => e.Copies).IsRequired(true);
                entity.Property(e => e.Price).IsRequired(true);
                entity.Property(e => e.EditionType).IsRequired(true);
                entity.Property(e => e.AgeRestriction).IsRequired(true);

                entity.HasOne(e => e.Author)
                      .WithMany(a => a.Books)
                      .HasForeignKey(e => e.AuthorId);
            });
            
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(true).IsRequired(true);
            });
            
            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.CategoryId });

                entity.HasOne(e => e.Book)
                      .WithMany(b => b.BookCategories)
                      .HasForeignKey(e => e.BookId);

                entity.HasOne(e => e.Category)
                      .WithMany(c => c.CategoryBooks)
                      .HasForeignKey(e => e.CategoryId);
            });
        }
    }