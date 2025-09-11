using System;

class Conditionals
{
    static void Main()
    {
        Console.WriteLine("1. Max.");
        Console.WriteLine("2. Product.");
        Console.WriteLine("3. Day of week.");
        Console.WriteLine("4. Exit.");   
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {   
                Console.WriteLine("Choose three numbers:");
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
                else if (c > a && c > b)
                {
                    max = c;   
                }
                Console.WriteLine("Max is " + max);
                break;
            }
            case 2:
            {  
                Console.WriteLine("Choose three numbers:"); 
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int product = 0;
                if (a < 0)
                {
                    product++;
                }

                if (b < 0)
                {
                    product++;
                }

                if (c < 0)
                {
                    product++;
                }

                if (product == 1 || product == 3)
                {
                    Console.WriteLine("Product is negative");
                }
                else
                {
                    Console.WriteLine("Product is positive");   
                }

                break;
            }
            case 3:
            {
                Console.WriteLine("Choose number of day");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                break;
            }
            case 4:
            {
                break;
            }
            default:
            {
                Console.WriteLine("Invalid choice.");
                break;
            }   
        }   
    }
}