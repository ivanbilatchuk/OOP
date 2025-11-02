namespace Task4;

public class Footman : Soldier
{
    public Footman(string name) : base(name, 2) { }

    public void Respond(object sender, EventArgs e)
    {
        if (IsAlive)
            Console.WriteLine($"Footman {Name} is panicking!");
    }
}
