namespace Task2;

public class Citizen : IIdentifiable, IBirthable, IBuyer
{
    public string Name { get; }
    public string Age { get; }
    public string Birthday { get; }
    public string Id { get; }
    public int Food { get; set; } = 0;
    public Citizen (string name, string age, string birthday, string id)
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