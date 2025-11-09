using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] range = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int start = range[0];
        int end = range[1];
        string command = Console.ReadLine();

        Predicate<int> filter;
        if (command == "even")
        {
            filter = n => n % 2 == 0;
        }
        else
        {
            filter = n => n % 2 != 0;
        }

        List<int> result = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (filter(i))
            {
                result.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}