namespace Task4;

public class RoyalGuard : Soldier
{
    public RoyalGuard(string name) : base(name, 3) { }

    public void Respond(object sender, EventArgs e)
    {
        if (IsAlive)
            Console.WriteLine($"Royal Guard {Name} is defending!");
    }
}