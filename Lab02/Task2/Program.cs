using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(' ');
        int n = parts.Length;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(parts[i]);
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
            if (i < n - 1)
            {
                Console.Write(" ");   
            } 
        }    
    }
}    
