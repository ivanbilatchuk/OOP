using System;

class NumManipulations
{
    static void Main()
    {
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                float a = int.Parse(Console.ReadLine());
                float b = int.Parse(Console.ReadLine());
                float c = int.Parse(Console.ReadLine());
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
                    int nDigit = number / (int)(Math.Pow(10, n - 1)) % 10;
                    Console.WriteLine(nDigit);
                }
                break;
            }    
        }
    }
}