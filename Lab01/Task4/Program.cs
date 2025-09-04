using System;

class Conditionals
{
    static void Main()
    {
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {   
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int max = 0;
                if (a > b && a > c)
                {
                    max = a;
                }    
                else if (b > a && b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;   
                }
                Console.WriteLine("Max is " + max);
                break;
            }    
        }   
    }
}