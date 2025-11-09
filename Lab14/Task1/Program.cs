using System;

class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        Action<string> action = new Action<string>(Console.WriteLine);
        foreach (string name in names)
        {
            action(name);
        }   
    }
}