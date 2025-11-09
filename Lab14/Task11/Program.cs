using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> guests = Console.ReadLine().Split(' ').ToList();
        List<Func<string, bool>> filters = new List<Func<string, bool>>();

        string input;
        while ((input = Console.ReadLine()) != "Print")
        {
            string[] parts = input.Split(';');
            string command = parts[0];
            string type = parts[1];
            string parameter = parts[2];

            Func<string, bool> filter = null;

            if (type == "Starts with")
            {
                filter = name => name.StartsWith(parameter);
            }
            else if (type == "Ends with")
            {
                filter = name => name.EndsWith(parameter);
            }
            else if (type == "Length")
            {
                filter = name => name.Length == int.Parse(parameter);
            }
            else if (type == "Contains")
            {
                filter = name => name.Contains(parameter);
            }

            if (command == "Add filter")
            {
                filters.Add(filter);
            }
            else if (command == "Remove filter")
            {
                filters.RemoveAll(f => f.Method.ToString() == filter.Method.ToString());
            }
        }

        foreach (var filter in filters)
        {
            guests = guests.Where(name => !filter(name)).ToList();
        }

        Console.WriteLine(string.Join(" ", guests));
    }
}