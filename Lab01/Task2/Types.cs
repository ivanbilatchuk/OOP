using System;

class Types
{
    static void Main()
    {
        Console.WriteLine("1. Integer.");
        Console.WriteLine("2. Double and float.");
        Console.WriteLine("3. String and char.");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                sbyte num1 = -100;
                byte num2 = 128;
                short num3 = -3540;
                ushort num4 = 64876;
                uint num5 = 2147483648;
                int num6 = -1141583228;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
                Console.WriteLine(num4);
                Console.WriteLine(num5);
                Console.WriteLine(num6);
                break;
            }
            case 2:
            {
                decimal num1 = 3.141592653589793238m;
                double num2 = 1.60217657;
                decimal num3 = 7.8184261974584555216535342341m;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
                break;
            }
            case 3:
            {
                string str = "Chernivtsi National University";
                char b = 'B';
                char y = 'y';
                char e = 'e';
                string str2 = "I love programming";
                Console.WriteLine(str);
                Console.WriteLine(b);
                Console.WriteLine(y);
                Console.WriteLine(e);
                Console.WriteLine(str2);
                break;
            }    
        }
    }
}