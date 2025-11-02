namespace Task2;

public delegate void KingAttackEventHandler();

public class King
{
    public string Name { get; }
    public event KingAttackEventHandler KingAttacked;

    public King(string name)
    {
        Name = name;
    }

    public void OnAttack()
    {
        Console.WriteLine($"King {Name} is under attack!");
        if (KingAttacked != null)
        {
            KingAttacked();
        }
    }
}