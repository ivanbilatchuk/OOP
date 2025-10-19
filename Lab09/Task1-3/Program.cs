using System;
using Task1;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Choose task (1-3");
        int task = int.Parse(Console.ReadLine());
        switch (task)
        {
            case 1:
                T1();
                break;
            case 2:
                T2();
                break;
            case 3:
                T3();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void T1()
    {
        string input = Console.ReadLine();
        var box = new Box<string>(input);
        Console.WriteLine(box);
    }

    static void T2()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            var box = new Box<string>(s);
            Console.WriteLine(box);
        }    
    }

    static void T3()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            var box = new Box<int>(num);
            Console.WriteLine(box);   
        }    
    }
    
}