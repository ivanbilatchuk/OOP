namespace Task4;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, double salary, string position, string department)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = "n/a";
        Age = -1;
    }
    

}