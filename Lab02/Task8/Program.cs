using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        const int maxVal = 65535;
        const int minVal = 0;
        
        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);

            if (arr[i] < minVal || arr[i] > maxVal)
            {
                Console.WriteLine($"Invalid number (it can be only from {minVal} to {maxVal}).");
                return;   
            }    
        }

        int[] arr2 = new int[maxVal];
        int max = 0;
        int mostFreq = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            arr2[num]++;
            if (arr2[num] > max)
            {
                max = arr2[num];
                mostFreq = num;
            }    
        }    
        Console.WriteLine($"Number {mostFreq} is the most frequent and occurs {max} times.");
    }
}
