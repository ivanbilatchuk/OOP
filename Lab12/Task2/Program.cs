using Task2;
using System;

class Program
{
    static King king;
    static List<RoyalGuard> royalGuards = new List<RoyalGuard>();
    static List<Footman> footmen = new List<Footman>();

    static void Main()
    {
        InitializeKingAndArmy();
        ProcessCommands();
    }
    static bool IsAlpha(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }

    static void InitializeKingAndArmy()
    {
        string kingName = Console.ReadLine();
        if (IsAlpha(kingName))
        {
            king = new King(kingName);
        }
        else
        {
            Console.WriteLine("Invalid king name!");
            return;
        }

        string[] royalNames = Console.ReadLine().Split(' ');
        for (int i = 0; i < royalNames.Length; i++)
        {
            if (IsAlpha(royalNames[i]))
            {
                RoyalGuard rg = new RoyalGuard(royalNames[i]);
                royalGuards.Add(rg);
                king.KingAttacked += rg.Respond;
            }
            else
            {
                Console.WriteLine($"Invalid name: '{royalNames[i]}'");
            }
        }

        string[] footmanNames = Console.ReadLine().Split(' ');
        for (int i = 0; i < footmanNames.Length; i++)
        {
            if (IsAlpha(footmanNames[i]))
            {
                Footman fm = new Footman(footmanNames[i]);
                footmen.Add(fm);
                king.KingAttacked += fm.Respond;
            }
            else
            {
                Console.WriteLine($"Invalid name: '{footmanNames[i]}'");
            }
        }
    }


    static void ProcessCommands()
    {
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            if (command == "Attack King")
            {
                king.OnAttack();
            }
            else if (command.StartsWith("Kill "))
            {
                string name = command.Substring(5);
                KillSoldier(name);
            }
        }
    }

    static void KillSoldier(string name)
    {
        for (int i = 0; i < royalGuards.Count; i++)
        {
            if (royalGuards[i].Name == name && royalGuards[i].IsAlive)
            {
                royalGuards[i].Die();
                king.KingAttacked -= royalGuards[i].Respond;
                return;
            }
        }

        for (int i = 0; i < footmen.Count; i++)
        {
            if (footmen[i].Name == name && footmen[i].IsAlive)
            {
                footmen[i].Die();
                king.KingAttacked -= footmen[i].Respond;
                return;
            }
        }
    }
}