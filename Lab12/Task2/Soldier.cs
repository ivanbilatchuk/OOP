namespace Task2;

public abstract class Soldier
{
    public string Name { get; }
    public bool IsAlive { get; private set; }

    protected Soldier(string name)
    {
        Name = name;
        IsAlive = true;
    }

    public void Die()
    {
        IsAlive = false;
    }

    public abstract void Respond();
}