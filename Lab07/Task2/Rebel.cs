namespace Task2;

public class Rebel
{
    public string Name { get; }
    public int Age { get; }
    public string Group { get; }
    public int Food { get; set; } = 0;
    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }
    public int BuyFood()
    {
        Food += 5;
        return 5;
    }
}