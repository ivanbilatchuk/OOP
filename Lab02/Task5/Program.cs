using System;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine().Replace(" ", "");
        string second = Console.ReadLine().Replace(" ", "");

        int i = 0;
        int minLength = Math.Min(first.Length, second.Length);
        int compare = 0;
        while (i < minLength)
        {
            if (first[i] < second[i])
            {
                compare = -1;
                break;
            }
            else if (first[i] > second[i])
            {
                compare = 1;
                break;
            }

            i++;
        }
        if (compare == 0)
        {
            if (first.Length < second.Length)
            {
                compare = -1;
            }
            else if (first.Length > second.Length)
            {
                compare = 1;
            }
        }

        if (compare <= 0)
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
        else
        {
            Console.WriteLine(second);
            Console.WriteLine(first);
        }
    }
}