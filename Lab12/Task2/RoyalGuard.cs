namespace Task2;

public class RoyalGuard : Soldier
{
    public RoyalGuard(string name) : base(name) { }

    public override void Respond()
    {
        if (IsAlive)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}