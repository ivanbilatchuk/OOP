using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first string");
        string[] arr1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter second string");
        string[] arr2 = Console.ReadLine().Split(' ');
        
        int minLength = Math.Min(arr1.Length, arr2.Length);

        int lCount = 0;
    
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] == arr2[i])
            {
                lCount++;
            }    
            else
            {
                break;
            }
        }
        
        int rCount = 0;
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
            {
                rCount++;
            }
            else
            {
                break; 
            }
        }
        if (lCount == 0 && rCount == 0)
        {
            Console.WriteLine("No common words");
        }
        else if (lCount >= rCount)
        {
            Console.WriteLine(lCount);
            for (int i = 0; i < lCount; i++)
            {
                Console.Write(arr1[i] + " ");
            }    
        }
        else if (rCount >= lCount)
        {
            Console.WriteLine(rCount);
            for (int i = arr1.Length - rCount; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }    
        }
    }
}