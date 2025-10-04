namespace Task2;

public class Worker : Human
{
    private decimal weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) :
        base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Excepted value mismatch! Argument: weekSalary!");
            }

            weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Excepted value mismatch! Argument: workHoursPerDay!");
            }

            workHoursPerDay = value;
        }
    }

    public decimal SalaryPerHour()
    {
        return WeekSalary / (decimal)(WorkHoursPerDay * 5);
    }

    public override string ToString()
    {
        return base.ToString() + $"\nWeek salary: {this.WeekSalary:f2}" +
               $"\nHours per day: {this.WorkHoursPerDay:f2}" +
               $"\nSalary per hour: {this.SalaryPerHour():f2}";
    }
}