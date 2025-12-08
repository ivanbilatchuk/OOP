using System.Globalization;
using System.Text;
using Bookshop;
using Bookshop.Data;
using Bookshop.Models;

public class StartUp
    {
        public static void Main(string[] args)
        {
            using var db = new BookShopContext();
            
            db.Database.EnsureCreated();
            SeedData.Initialize(db);
            
            Console.WriteLine("Database ready.\n");

            while (true)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Select task number (2-16) or '0' to exit:");
                Console.Write("> ");

                string choice = Console.ReadLine();

                if (choice == "0") break;

                switch (choice)
                {
                    case "2":
                        Console.WriteLine("Task 2: Age Restriction");
                        Console.Write("Enter restriction (Minor, Teen, Adult): ");
                        string command = Console.ReadLine();
                        Console.WriteLine(GetBooksByAgeRestriction(db, command));
                        break;

                    case "3":
                        Console.WriteLine("Task 3: Golden Books");
                        Console.WriteLine(GetGoldenBooks(db));
                        break;

                    case "4":
                        Console.WriteLine("Task 4: Books by Price");
                        Console.WriteLine(GetBooksByPrice(db));
                        break;

                    case "5":
                        Console.WriteLine("Task 5: Not Released In");
                        Console.Write("Enter year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetBooksNotReleasedIn(db, year));
                        break;

                    case "6":
                        Console.WriteLine("Task 6: Book Titles by Category");
                        Console.Write("Enter categories (space separated): ");
                        string cats = Console.ReadLine();
                        Console.WriteLine(GetBooksByCategory(db, cats));
                        break;

                    case "7":
                        Console.WriteLine("Task 7: Released Before Date");
                        Console.Write("Enter date (dd-MM-yyyy): ");
                        string date = Console.ReadLine();
                        Console.WriteLine(GetBooksReleasedBefore(db, date));
                        break;

                    case "8":
                        Console.WriteLine("Task 8: Author Search");
                        Console.Write("Enter name ending: ");
                        string endStr = Console.ReadLine();
                        Console.WriteLine(GetAuthorNamesEndingIn(db, endStr));
                        break;

                    case "9":
                        Console.WriteLine("Task 9: Book Search");
                        Console.Write("Enter book title part: ");
                        string titlePart = Console.ReadLine();
                        Console.WriteLine(GetBookTitlesContaining(db, titlePart));
                        break;

                    case "10":
                        Console.WriteLine("Task 10: Book Search by Author");
                        Console.Write("Enter author last name start: ");
                        string authStart = Console.ReadLine();
                        Console.WriteLine(GetBooksByAuthor(db, authStart));
                        break;

                    case "11":
                        Console.WriteLine("Task 11: Count Books");
                        Console.Write("Enter title length: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine(CountBooks(db, length));
                        break;

                    case "12":
                        Console.WriteLine("Task 12: Total Book Copies");
                        Console.WriteLine(CountCopiesByAuthor(db));
                        break;

                    case "13":
                        Console.WriteLine("Task 13: Profit by Category");
                        Console.WriteLine(GetTotalProfitByCategory(db));
                        break;

                    case "14":
                        Console.WriteLine("Task 14: Most Recent Books");
                        Console.WriteLine(GetMostRecentBooks(db));
                        break;

                    case "15":
                        Console.WriteLine("Task 15: Increase Prices (Released before 2010)");
                        IncreasePrices(db);
                        Console.WriteLine("Prices increased!");
                        break;

                    case "16":
                        Console.WriteLine("Task 16: Remove Books");
                        int removed = RemoveBooks(db);
                        Console.WriteLine($"{removed} books were deleted");
                        break;

                    default:
                        Console.WriteLine("Invalid task number.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            if (!Enum.TryParse(command, true, out AgeRestriction ageRestriction))
                return string.Empty;

            var books = context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => $"{b.Title} - ${b.Price:F2}")
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var books = context.Books
                .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var targetDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value < targetDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:F2}")
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorsData = context.Authors
                .Where(a => a.FirstName != null && a.FirstName.EndsWith(input))
                .Select(a => new 
                { 
                    a.FirstName, 
                    a.LastName 
                })
                .ToList();
            var formattedNames = authorsData
                .Select(a => $"{a.FirstName} {a.LastName}") 
                .OrderBy(n => n)                          
                .ToList();

            return string.Join(Environment.NewLine, formattedNames);
        }
        
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var titles = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToList();

            return string.Join(Environment.NewLine, titles);
        }
        
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.Count(b => b.Title.Length > lengthCheck);
        }
        
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                .Select(a => new
                {
                    Name = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.Copies)
                .ToList();

            return string.Join(Environment.NewLine, authors.Select(a => $"{a.Name} - {a.Copies}"));
        }
        
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Profit = c.CategoryBooks.Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.Name)
                .ToList();

            return string.Join(Environment.NewLine, categories.Select(c => $"{c.Name} ${c.Profit:F2}"));
        }
        
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .OrderByDescending(c => c.CategoryBooks.Count)
                .Select(c => new
                {
                    c.Name,
                    TopBooks = c.CategoryBooks
                        .OrderByDescending(cb => cb.Book.ReleaseDate)
                        .Take(3)
                        .Select(cb => new { cb.Book.Title, Year = cb.Book.ReleaseDate.Value.Year })
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var c in categories)
            {
                sb.AppendLine($"--{c.Name}");
                foreach (var b in c.TopBooks)
                {
                    sb.AppendLine($"{b.Title} ({b.Year})");
                }
            }
            return sb.ToString().TrimEnd();
        }
        
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010);
            
            foreach (var book in books)
            {
                book.Price += 5;
            }
            context.SaveChanges();
        }
        
        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(b => b.Copies < 4200).ToList();
            context.Books.RemoveRange(books);
            context.SaveChanges();
            return books.Count;
        }
    }