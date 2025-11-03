namespace Task4;

public abstract class Soldier
{
    public string Name { get; }
    public int Health { get; protected set; }
    public bool IsAlive 
    {
        get { return Health > 0; }
    }

    public event EventHandler Died;

    protected Soldier(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage()
    {
        Health--;
        if (Health <= 0)
        {
            Died?.Invoke(this, EventArgs.Empty);
        }
    }
}