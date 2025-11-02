namespace Task2;

public class Footman : Soldier
{
    public Footman(string name) : base(name) { }

    public override void Respond()
    {
        if (IsAlive)
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}