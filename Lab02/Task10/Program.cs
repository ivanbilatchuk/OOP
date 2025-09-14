using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] array = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        int difference = int.Parse(Console.ReadLine());
        if (difference < 0)
        {
            Console.WriteLine("Difference cannot be negative.");
        }
        else
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] - array[j] == difference || array[j] - array[i] == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}