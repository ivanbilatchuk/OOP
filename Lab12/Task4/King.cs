namespace Task4;

public class King
{
    public string Name { get; }
    public event EventHandler KingAttacked;

    public King(string name)
    {
        Name = name;
    }

    public void OnAttack()
    {
        Console.WriteLine($"King {Name} is under attack!");
        KingAttacked?.Invoke(this, EventArgs.Empty);
    }
}