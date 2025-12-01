using System;
using System.Linq;
using Task3_5.Data;
using Task3.Data.Models;

namespace P03_SalesDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new SalesContext();
            
            if (!db.Products.Any())
            {
                Console.WriteLine("Generating data...");
                var rnd = new Random();

                var products = new[]
                {
                    new Product { Name = "Video Card", Quantity = 5, Price = 500 },
                    new Product { Name = "HDD", Quantity = 20, Price = 60 },
                    new Product { Name = "Monitor", Quantity = 10, Price = 150 }
                };
                db.Products.AddRange(products);

                var customers = new[]
                {
                    new Customer { Name = "Dmytro", Email = "d@test.com", CreditCardNumber = "1234" },
                    new Customer { Name = "Olga", Email = "o@test.com", CreditCardNumber = "5678" }
                };
                db.Customers.AddRange(customers);

                var store = new Store { Name = "TechStore" };
                db.Stores.Add(store);

                db.SaveChanges();

                db.Sales.Add(new Sale 
                { 
                    Product = products[0], 
                    Customer = customers[0], 
                    Store = store 
                });

                db.SaveChanges();
                Console.WriteLine("Data added successfully!");
            }

            var sale = db.Sales.First();
            var prod = db.Products.First();

            Console.WriteLine("\nVerification:");
            Console.WriteLine($"1. Product Description: '{prod.Description}'");
            Console.WriteLine($"2. Sale Date: '{sale.Date}'");
        }
    }
}