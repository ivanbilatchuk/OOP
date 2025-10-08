namespace Task2;

public class Citizen : IIdentifiable, IBirthable, IBuyer
{
    public string Name { get; }
    public int Age { get; }
    public string Birthday { get; }
    public string Id { get; }
    public int Food { get; set; } = 0;
    public Citizen (string name, int age, string birthday, string id)
    {
        Name = name;
        Age = age;
        Birthday = birthday;
        Id = id;
    }
    
    public int BuyFood()
    {
        Food += 10;
        return 10;
    }
}