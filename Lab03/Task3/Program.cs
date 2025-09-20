using Task1;
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();
        family.members = new Person[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0];
            int age = int.Parse(input[1]);
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
                return;
            }
            else
            {
                Person pers = new Person(name, age);
                family.AddMember(pers, i);
            }
        }

        Person oldest = family.GetOldestMember();
        Console.WriteLine($"{oldest.Name} {oldest.Age}"); 
    }
}