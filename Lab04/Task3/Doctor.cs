namespace Task3;

public class Doctor
{
    public string Name { get; set; }
    public Patient[] Patients = new Patient[200];
    public int PatientsCount = 0;
}