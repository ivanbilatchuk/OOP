using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        foreach (char c in word)
        {
            if (c >= 'a' && c <= 'z')
            {
                int index = c - 'a';
                Console.WriteLine($"{c} -> {index}");  
            }
            else if (c >= 'A' && c <= 'Z')
            {
                int index = c - 'A';
                Console.WriteLine($"{c} -> {index}");  
            }
            else
            {
                Console.WriteLine($"{c} -> isn't a letter");
            }
        }    
    }
}