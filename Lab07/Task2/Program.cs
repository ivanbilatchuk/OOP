using Task2;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a chapter (1, 2 or 3):");
        int chapter = int.Parse(Console.ReadLine());
        switch (chapter)
        {
            case 1:
                BorderControl();
                break;
            case 2:
                Birthdays();
                break;
            case 3:
                FoodShortage();
                break;
            default:
                Console.WriteLine("Invalid chapter.");
                break;
        }
    }

    static void BorderControl()
    {
        string[] ids = new string[100];
        int count = 0;
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputArr = input.Split(' ');
            string id = inputArr[inputArr.Length - 1];
            ids[count++] = id;
        }    
        string ending = Console.ReadLine();
        for (int i = 0; i < count; i++)
        {
            if (ids[i].EndsWith(ending))
            {
                Console.WriteLine(ids[i]);
            }   
        }    
    }
    static void Birthdays()
    {
        IBirthable[] birthables = new IBirthable[100];
        int count = 0;
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split(' ');
            if (parts[0] == "Citizen")
            {
                string name = parts[1];
                int age = int.Parse(parts[2]);
                string id = parts[3];
                string birth = parts[4];
                birthables[count] = new Citizen(name, age, birth, id);
                count++;
            }
            else if (parts[0] == "Pet")
            {
                string name = parts[1];
                string birth = parts[2];
                birthables[count] = new Pet(name, birth);
                count++;
            }   
        }    
        string year = Console.ReadLine();
        for (int i = 0; i < count; i++)
        {
            if (birthables[i].Birthday.EndsWith(year)) 
            { 
                Console.WriteLine(birthables[i].Birthday); 
            }
        }   
    }

    static void FoodShortage()
    {
        int n = int.Parse(Console.ReadLine());
        string[] names = new string[n];
        IBuyer[] buyers = new IBuyer[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            if (parts.Length == 4)
            {
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string id = parts[2];
                string birth = parts[3];
                buyers[count] = new Citizen(name, age, id, birth);
                names[count] = name;
                count++;
            }    
            else if (parts.Length == 3)
            {
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string group = parts[2];
                buyers[count] = new Rebel(name, age, group);
                names[count] = name;
                count++;
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            for (int i = 0; i < count; i++)
            {
                if (names[i] == input)
                {
                    buyers[i].BuyFood();
                }    
            }    
        }    
        int totalFood = 0;
        for (int i = 0; i < count; i++)
        {
            totalFood += buyers[i].Food;
        }    
        Console.WriteLine(totalFood);
    }
}