namespace Task3;

public class Department
{
    public string Name { get; set; }
    public Patient[] Patients = new Patient[60];
    public int PatientsCount = 0;
}