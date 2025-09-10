using System;

class NumManipulations
{
    static void Main()
    {
        Console.WriteLine("1. Average.");
        Console.WriteLine("2. Area.");
        Console.WriteLine("3. Last digit.");
        Console.WriteLine("4. N digit.");
        Console.WriteLine("5. Check odd and bigger than 20.");
        Console.WriteLine("6. Check division by 9, 11, 13.");
        Console.WriteLine("7. Exit.");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                float average = (a + b + c) / 3;
                Console.WriteLine("Average is " + average);
                break;
            }
            case 2:
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (a + b) * h / 2;
                Console.WriteLine("Area is " + area);
                break;
            }
            case 3:
            {
                int n = int.Parse(Console.ReadLine());
                int lastDigit = n % 10;
                Console.WriteLine("Last digit is " + lastDigit);
                break;
            }
            case 4:
            {
                int n = int.Parse(Console.ReadLine());
                int number = int.Parse(Console.ReadLine());
                if (number < Math.Pow(10, n - 1))
                {
                    Console.WriteLine("-");
                }
                else
                {
                    int nDigit = (number / (int)(Math.Pow(10, n - 1))) % 10;
                    Console.WriteLine(nDigit);
                }
                break;
            }
            case 5:
            {
                int n = int.Parse(Console.ReadLine());
                bool result;
                if (n % 2 == 1 && n > 20)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }    
                Console.WriteLine(result);
                break;
            }
            case 6:
            {
                int n = int.Parse(Console.ReadLine());
                bool result;
                if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }    
                Console.WriteLine(result);
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