using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Person[] people = ReadPeople();
                Product[] products = ReadProducts();
                ProcessPurchases(people, products);
                PrintRes(people);   
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }

        static Person[] ReadPeople()
        {
            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            Person[] people = new Person[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string[] parts = input[i].Split('=');
                string name = parts[0];
                decimal money = decimal.Parse(parts[1]);
                people[i] = new Person(name, money);
            }
            return people;
        }

        static Product[] ReadProducts()
        {
            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            Product[] products = new Product[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string[] parts = input[i].Split('=');
                string name = parts[0];
                decimal price = decimal.Parse(parts[1]);
                products[i] = new Product(name, price);
            }
            return products;
        }

        static Person FindPerson(Person[] people, string name)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Name == name)
                {
                    return people[i];
                }    
            }
            return null;
        }

        static Product FindProduct(Product[] products, string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    return products[i];
                }    
            }
            return null;
        }
        static void PrintRes(Person[] people)
        {
            for(int i = 0; i < people.Length; i++)
            {
                people[i].Print();
            }
        }

        static void ProcessPurchases(Person[] people, Product[] products)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToUpper() == "END")
                {
                    break;
                }

                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string PersonName = parts[0];
                string ProductName = parts[1];
                Person person = FindPerson(people, PersonName);
                Product product = FindProduct(products, ProductName);
                if (person != null && product != null)
                {
                    person.BuyProduct(product);
                }    
            }    
        }
    }   
}