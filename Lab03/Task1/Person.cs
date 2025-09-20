namespace Task1;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }

    public Person()
    {
        name = "John";
        age = 18;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;   
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");   
    }
}
