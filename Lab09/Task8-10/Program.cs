using System;
using Task8_10;

class Program
{
    static void Main()
    {
        CustomList<string> list = new CustomList<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] parts = input.Split(' ');
            string command = parts[0];
            switch (command)
            {
                case "Add":
                    list.Add(parts[1]);
                    break;
                case "Remove":
                    list.Remove(int.Parse(parts[1]));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(parts[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(parts[1]), int.Parse(parts[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(parts[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());  
                    break;
                case "Min":
                    Console.WriteLine(list.Min());  
                    break;
                case "Print":
                    list.Print();
                    break;
                case "Sort":
                    Sorter.Sort(list);
                    break;
                default:
                    Console.WriteLine("Invalid command.");   
                    break;   
            }
        }    
    }
}