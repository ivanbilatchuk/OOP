using Task6_7;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose task 1 or 2");
        int task = int.Parse(Console.ReadLine());
        switch (task)
        {
            case 1:
                T6();
                break;
            case 2:
                T7();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static int CountGreaterThan<T>(List<Box<T>> list, Box<T> element) where T : IComparable<T>
    {
        int count = 0;
        foreach (var box in list)
        {
            if (box.CompareTo(element) > 0)
            {
                count++;
            }
        }    
        return count;
    }

    static void T6()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> boxes = new List<Box<string>>();
        for (int i = 0; i < n; i++)
        {
            boxes.Add(new Box<string>(Console.ReadLine()));
        }
        string value = Console.ReadLine(); 
        var compareBox = new Box<string>(value);
        Console.WriteLine(CountGreaterThan(boxes, compareBox));
    }

    static void T7()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<double>> boxes = new List<Box<double>>();
        for (int i = 0; i < n; i++)
        {
            boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
        }    
        double value = double.Parse(Console.ReadLine());
        var compareBox = new Box<double>(value);
        Console.WriteLine(CountGreaterThan(boxes, compareBox));   
    }
}