using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> guests = Console.ReadLine().Split(' ').ToList();
        string input;
        
        while ((input = Console.ReadLine()) != "Party!")
        {
            string[] parts = input.Split(' ');
            string command = parts[0];
            string criterion = parts[1];
            string argument = parts[2];

            Predicate<string> predicate = null;

            if (criterion == "StartsWith")
            {
                predicate = name => name.StartsWith(argument);
            }
            else if (criterion == "EndsWith")
            {
                predicate = name => name.EndsWith(argument);
            }
            else if (criterion == "Length")
            {
                predicate = name => name.Length == int.Parse(argument);
            }

            if (command == "Remove")
            {
                guests.RemoveAll(predicate);
            }
            else if (command == "Double")
            {
                List<string> toAdd = guests.Where(name => predicate(name)).ToList();
                guests.AddRange(toAdd);
            }
        }

        if (guests.Count > 0)
        {
            Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}