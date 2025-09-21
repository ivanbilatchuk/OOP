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
            if (value < 0)
            {
                age = 0;
            }
            else
            {
                age = value;
            }
        }
    }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;   
    }

    public Person() 
    {
        Name = "No name";
        Age = -1;  
    }

    public Person(int age)
    {
        Name = "No name";
        Age = age; 
    }
    
    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");   
    }
}
