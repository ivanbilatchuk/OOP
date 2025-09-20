using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = input.Length;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
        int k = int.Parse(Console.ReadLine());
        int[] sum = new int[n];
        for (int r = 1; r <= k; r++)
        {
            for (int i = 0; i < n; i++)
            {
                int pos = (i + r) % n;
                sum[pos] += arr[i];   
            }    
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(sum[i] + " ");
        }    
    }
}    
