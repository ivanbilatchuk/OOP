using System;
using Task1;

class Program
{
    static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split(' ');
        string[] urls = Console.ReadLine().Split(' ');
        Smartphone smartphone = new Smartphone();
        foreach (string number in phoneNumbers)
        {
            Console.WriteLine(smartphone.Call(number));
        }
        foreach (string url in urls)
        {
            Console.WriteLine(smartphone.Browse(url));
        }
    }
}