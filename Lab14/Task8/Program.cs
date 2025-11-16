using System;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Comparison<int> customComparator = (a, b) =>
        {
            if (a % 2 == 0 && b % 2 != 0)
            {
                return -1;
            }

            if (a % 2 != 0 && b % 2 == 0)
            {
                return 1;
            }
            return a.CompareTo(b);
        };

        Array.Sort(numbers, customComparator);

        Console.WriteLine(string.Join(" ", numbers));
    }
}