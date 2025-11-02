namespace Task3;

public class Job
{
    public string Name { get; }
    public int HoursRequired { get; private set; }
    public IEmployee Employee { get; }

    public event EventHandler JobDone;

    public Job(string name, int hoursRequired, IEmployee employee)
    {
        Name = name;
        HoursRequired = hoursRequired;
        Employee = employee;
    }

    public void Update()
    {
        HoursRequired -= Employee.WorkHoursPerWeek;
        if (HoursRequired <= 0)
        {
            Console.WriteLine($"Job {Name} done!");
            JobDone?.Invoke(this, EventArgs.Empty);
        }
    }

    public override string ToString()
    {
        return $"Job: {Name} Hours Remaining: {HoursRequired}";
    }
}