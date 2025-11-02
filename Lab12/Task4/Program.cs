using Task4;

class Program
{
    static King king;
    static List<RoyalGuard> royalGuards = new List<RoyalGuard>();
    static List<Footman> footmen = new List<Footman>();

    static void Main()
    {
        king = new King(Console.ReadLine());

        foreach (var name in Console.ReadLine().Split(' '))
        {
            var rg = new RoyalGuard(name);
            rg.Died += SoldierDied;
            royalGuards.Add(rg);
            king.KingAttacked += rg.Respond;
        }

        foreach (var name in Console.ReadLine().Split(' '))
        {
            var fm = new Footman(name);
            fm.Died += SoldierDied;
            footmen.Add(fm);
            king.KingAttacked += fm.Respond;
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            if (command == "Attack King")
                king.OnAttack();
            else if (command.StartsWith("Kill "))
                DamageSoldier(command.Substring(5));
        }
    }

    static void DamageSoldier(string name)
    {
        foreach (var rg in royalGuards)
            if (rg.Name == name && rg.IsAlive)
            { rg.TakeDamage(); return; }

        foreach (var fm in footmen)
            if (fm.Name == name && fm.IsAlive)
            { fm.TakeDamage(); return; }
    }

    static void SoldierDied(object sender, EventArgs e)
    {
        if (sender is RoyalGuard rg)
        {
            king.KingAttacked -= rg.Respond;
            royalGuards.Remove(rg);
        }
        else if (sender is Footman fm)
        {
            king.KingAttacked -= fm.Respond;
            footmen.Remove(fm);
        }
    }
}