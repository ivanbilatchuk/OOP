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

    static void InitializeKingAndArmy()
    {
        king = new King(Console.ReadLine());

        string[] royalNames = Console.ReadLine().Split(' ');
        for (int i = 0; i < royalNames.Length; i++)
        {
            RoyalGuard rg = new RoyalGuard(royalNames[i]);
            royalGuards.Add(rg);
            king.KingAttacked += rg.Respond;
        }

        string[] footmanNames = Console.ReadLine().Split(' ');
        for (int i = 0; i < footmanNames.Length; i++)
        {
            Footman fm = new Footman(footmanNames[i]);
            footmen.Add(fm);
            king.KingAttacked += fm.Respond;
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