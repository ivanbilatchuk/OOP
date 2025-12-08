using Bookshop.Data;
using Bookshop.Models;

namespace Bookshop;

public static class SeedData
    {
        public static void Initialize(BookShopContext context)
        {
            if (context.Books.Any()) return;
            var authors = new[]
            {
                new Author { FirstName = "Stanko", LastName = "Popov" },
                new Author { FirstName = "Lyubov", LastName = "Ivanova" },
                new Author { FirstName = "Jane", LastName = "Ortiz" },
                new Author { FirstName = "George", LastName = "Powell" },
                new Author { FirstName = "Randy", LastName = "Morales" },
                new Author { FirstName = "Stephen", LastName = "King" },
                new Author { FirstName = "Agatha", LastName = "Christie" }
            };
            context.Authors.AddRange(authors);
            context.SaveChanges();
            
            var categories = new[]
            {
                new Category { Name = "Action" },
                new Category { Name = "Adventure" },
                new Category { Name = "Drama" },
                new Category { Name = "Fantasy" },
                new Category { Name = "Horror" },
                new Category { Name = "Mystery" },
                new Category { Name = "Romance" },
                new Category { Name = "Science Fiction" }
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();
            var books = new List<Book>
            {
                new Book { Title = "Lilies of the Field", Description = "Desc...", ReleaseDate = new DateTime(1995, 5, 12), Copies = 4500, Price = 15.00m, EditionType = EditionType.Gold, AgeRestriction = AgeRestriction.Adult, Author = authors[0] },
                new Book { Title = "Look Homeward", Description = "Desc...", ReleaseDate = new DateTime(1998, 1, 20), Copies = 3000, Price = 18.50m, EditionType = EditionType.Gold, AgeRestriction = AgeRestriction.Teen, Author = authors[1] },
                new Book { Title = "O Pioneers!", Description = "Desc...", ReleaseDate = new DateTime(2005, 6, 15), Copies = 10000, Price = 49.90m, EditionType = EditionType.Normal, AgeRestriction = AgeRestriction.Adult, Author = authors[2] },
                new Book { Title = "That Hideous Strength", Description = "Desc...", ReleaseDate = new DateTime(2008, 3, 10), Copies = 8000, Price = 48.63m, EditionType = EditionType.Normal, AgeRestriction = AgeRestriction.Adult, Author = authors[2] },
                new Book { Title = "A Confederacy of Dunces", Description = "Desc...", ReleaseDate = new DateTime(1999, 11, 5), Copies = 15000, Price = 12.00m, EditionType = EditionType.Promo, AgeRestriction = AgeRestriction.Minor, Author = authors[3] },
                new Book { Title = "A Passage to India", Description = "Desc...", ReleaseDate = new DateTime(1924, 1, 1), Copies = 20000, Price = 14.00m, EditionType = EditionType.Normal, AgeRestriction = AgeRestriction.Teen, Author = authors[4] },
                new Book { Title = "Brandy of the Damned", Description = "Desc...", ReleaseDate = new DateTime(2015, 10, 10), Copies = 5500, Price = 25.00m, EditionType = EditionType.Promo, AgeRestriction = AgeRestriction.Adult, Author = authors[0] },
                new Book { Title = "The Cricket on the Hearth", Description = "Desc...", ReleaseDate = new DateTime(2013, 12, 1), Copies = 6000, Price = 19.00m, EditionType = EditionType.Normal, AgeRestriction = AgeRestriction.Minor, Author = authors[1] },
                new Book { Title = "Cheap Book", Description = "Delete me", ReleaseDate = new DateTime(2020, 1, 1), Copies = 100, Price = 5.00m, EditionType = EditionType.Normal, AgeRestriction = AgeRestriction.Minor, Author = authors[5] }
            };

            context.Books.AddRange(books);
            context.SaveChanges();
            var bookCategories = new List<BookCategory>
            {
                new BookCategory { Book = books[0], Category = categories[5] },
                new BookCategory { Book = books[1], Category = categories[3] },
                new BookCategory { Book = books[2], Category = categories[2] },
                new BookCategory { Book = books[2], Category = categories[4] },
                new BookCategory { Book = books[3], Category = categories[7] },
                new BookCategory { Book = books[6], Category = categories[0] }, // Action
                new BookCategory { Book = books[7], Category = categories[1] }, // Adventure
            };
            context.BooksCategories.AddRange(bookCategories);
            context.SaveChanges();
        }
    }