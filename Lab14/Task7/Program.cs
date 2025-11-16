using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(' ');

        Predicate<string> filter = name => name.Length <= n;

        foreach (string name in names)
        {
            if (filter(name))
            {
                Console.WriteLine(name);
            }
        }
    }
}