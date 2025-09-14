using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = input.Length;
        if (n % 4 != 0)
        {
            Console.WriteLine("Invalid length.");
            return;  
        }
        else
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int k = n / 4;
            int[] first = new int[2 * k];
            int[] second = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                first[i] = arr[k - 1 - i];
            }

            for (int i = 0; i < k; i++)
            {
                first[k + i] = arr[n - 1 - i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                second[i] = arr[k + i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                int sum = first[i] + second[i];
                Console.Write(sum + " ");
            }
        }
    }
}