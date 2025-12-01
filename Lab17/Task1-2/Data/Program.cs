using Task1.Data.Models;

namespace Task1.Data;

public class Program
{
    static void Main()
    {
        using var db = new HospitalContext();
        db.Database.EnsureCreated();

        if (!db.Doctors.Any())
        {
            db.Doctors.Add(new Doctor { Name = "House", Email = "admin", Password = "admin", Specialty = "Doc" });
            db.SaveChanges();
            Console.WriteLine("Created admin/admin user.");
        }

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();
        Console.Write("Enter Password: ");
        string pass = Console.ReadLine();

        var doc = db.Doctors.FirstOrDefault(d => d.Email == email && d.Password == pass);
        if (doc == null)
        {
            Console.WriteLine("Wrong login.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\n1. List Patients | 2. Add Patient | 0. Exit");
            string choice = Console.ReadLine();

            if (choice == "0") break;

            if (choice == "1")
            {
                foreach (var p in db.Patients)
                    Console.WriteLine($"{p.FirstName} {p.LastName} (Insured: {p.HasInsurance})");
            }
            else if (choice == "2")
            {
                Console.Write("First Name: "); 
                var fName = Console.ReadLine();
            
                Console.Write("Last Name: "); 
                var lName = Console.ReadLine();
            
                Console.Write("Address: "); 
                var address = Console.ReadLine();
            
                Console.Write("Email: "); 
                var mail = Console.ReadLine();  
            
                Console.Write("Has Insurance? (y/n): "); 
                bool isInsured = Console.ReadLine() == "y"; 
                db.Patients.Add(new Patient 
                { 
                    FirstName = fName, 
                    LastName = lName, 
                    Address = address, 
                    Email = mail, 
                    HasInsurance = isInsured 
                });
                db.SaveChanges();
                Console.WriteLine("Saved!");
            }
        }
    }
}