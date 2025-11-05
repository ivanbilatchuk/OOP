namespace Task5;

public class Pet
{
    public string Name { get; }
    public int Age { get; }
    public string Kind { get; }

    public Pet(string name, int age, string kind)
    {
        Name = name;
        Age = age;
        Kind = kind;
    }

    public override string ToString()
    {
        return $"{Name} {Age} {Kind}";
    }
}