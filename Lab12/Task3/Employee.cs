namespace Task3;

public interface IEmployee
{
    string Name { get; }
    int WorkHoursPerWeek { get; }
}

public class StandardEmployee : IEmployee
{
    public string Name { get; }
    public int WorkHoursPerWeek => 40;

    public StandardEmployee(string name)
    {
        Name = name;
    }
}

public class PartTimeEmployee : IEmployee
{
    public string Name { get; }
    public int WorkHoursPerWeek => 20;

    public PartTimeEmployee(string name)
    {
        Name = name;
    }
}