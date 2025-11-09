using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] divisors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Func<int, bool> isDivisible = num =>
        {
            foreach (int d in divisors)
            {
                if (d != 0 && num % d != 0)
                {
                    return false;
                }
            }
            return true;
        };

        for (int i = 1; i <= N; i++)
        {
            if (isDivisible(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}