namespace Task3;

public class Repair
{
    public string PartName { get; }
    public int HoursWorked { get; }

    public Repair(string partName, int hoursWorked)
    {
        PartName = partName;
        HoursWorked = hoursWorked;
    }    
    public override string ToString()
    {
        return $"Part Name : {PartName} Hours worked: {HoursWorked}";
    }   
}