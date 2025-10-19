using System;
using System.Numerics;
using Lab09;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose 1 or 2");
        int task = int.Parse(Console.ReadLine());
        switch (task)
        {
            case 1 :
                T4();
                break;
            case 2 :
                T5();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void Swap<T>(List<T> list, int i, int j)
    {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

    static void T4()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> boxes = new List<Box<string>>();
        for (int i = 0; i < n; i++)
        {
            boxes.Add(new Box<string>(Console.ReadLine()));
        }

        string[] idx = Console.ReadLine().Split(' ');
        int i1 = int.Parse(idx[0]);
        int i2 = int.Parse(idx[1]);
        Swap(boxes, i1, i2);
        foreach (var box in boxes)
        {
            Console.WriteLine(box);
        }    
    }

    static void T5()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<int>> boxes = new List<Box<int>>();
        for (int i = 0; i < n; i++)
        {
            boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
        }
        string[] idx = Console.ReadLine().Split(' ');
        int i1 = int.Parse(idx[0]);
        int i2 = int.Parse(idx[1]);
        Swap(boxes, i1, i2);
        foreach (var box in boxes)
        {
            Console.WriteLine(box);
        }   
    }
}    
