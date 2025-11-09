using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> gems = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<Func<int, int, bool>> filters = new List<Func<int, int, bool>>();
        string input;

        while ((input = Console.ReadLine()) != "Forge")
        {
            string[] parts = input.Split(';');
            string command = parts[0];
            string filterType = parts[1];
            int parameter = int.Parse(parts[2]);

            Func<int, int, bool> filter = (index, value) =>
            {
                int left;
                if (index > 0)
                {
                    left = gems[index - 1];
                }
                else
                {
                    left = 0;
                }

                int right;
                if (index < gems.Count - 1)
                {
                    right = gems[index + 1];
                }
                else
                {
                    right = 0;
                }


                if (filterType == "Sum Left")
                {
                    return left + value == parameter;
                }

                if (filterType == "Sum Right")
                {
                    return value + right == parameter;
                }

                if (filterType == "Sum Left Right")
                {
                    return left + value + right == parameter;
                }
                return false;
            };

            if (command == "Exclude")
            {
                filters.Add(filter);
            }
            else if (command == "Reverse")
            {
                filters.RemoveAll(f => f.Method.ToString() == filter.Method.ToString());
            }
        }

        List<int> result = new List<int>();

        for (int i = 0; i < gems.Count; i++)
        {
            bool excluded = false;
            foreach (var filter in filters)
            {
                if (filter(i, gems[i]))
                {
                    excluded = true;
                    break;
                }
            }

            if (!excluded)
            {
                result.Add(gems[i]);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}