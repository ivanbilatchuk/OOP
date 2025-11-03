using System;
using System.Collections.Generic;
using Task2;

class Program
{
    static void Main()
    {
        ListyIterator<string> listyIterator = null;

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = parts[0];

            try
            {
                switch (command)
                {
                    case "Create":
                        List<string> elements = new List<string>();
                        if (parts.Length > 1)
                        {
                            for (int i = 1; i < parts.Length; i++)
                                elements.Add(parts[i]);
                        }
                        listyIterator = new ListyIterator<string>(elements);
                        break;

                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;

                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;

                    case "Print":
                        listyIterator.Print();
                        break;

                    case "PrintAll":
                        listyIterator.PrintAll(); 
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}