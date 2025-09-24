namespace Task3;

public class Hospital
{
    private Department[] departments = new Department[100];
    private int depCount = 0;
    private Doctor[] doctors = new Doctor[100];
    private int docCount = 0;

    public void AddPatient(string departmentName, string doctorName, string patientName)
    {
        
    }
    
    private Department FindOrAddDepartment(string name)
    {
        for (int i = 0; i < depCount; i++)
        {
            if (departments[i].Name == name)
            {
                return departments[i];
            }    
        }    
        Department department = new Department() { Name = name };
        departments[depCount++] = department;
        return department;
    }
    private Doctor FindOrAddDoctor(string name)
    {
        for (int i = 0; i < docCount; i++)
        {
            if (doctors[i].Name == name)
            {
                return doctors[i];
            }    
        }    
        Doctor doctor = new Doctor() { Name = name };
        doctors[docCount++] = doctor;
        return doctor;
    }
    public void PrintDepartment(string name)
    {
        for (int i = 0; i < depCount; i++)
        {
            if (departments[i].Name == name)
            {
                for (int j = 0; j < departments[i].PatientsCount; j++)
                {
                    Console.WriteLine(departments[i].Patients[j].Name);   
                }    
            }   
        }    
    }

    public void PrintDepRoom(string name, int room)
    {
        for (int i = 0; i < depCount; i++)
        {
            if (departments[i].Name == name)
            {
                int start = (room - 1) * 3;
                int end = Math.Min(start + 3, departments[i].PatientsCount);
                string[] names = new string[end - start];
                int count = 0;
                for (int j = start; j < end; j++)
                {
                    names[count++] = departments[i].Patients[j].Name;
                }    
                Array.Sort(names, 0, count);
                for (int j = 0; j < count; j++)
                {
                    Console.WriteLine(names[j]);
                }   
            }    
        }    
    }

    public void PrintDoctor(string name)
    {
        for (int i = 0; i < docCount; i++)
        {
            if (doctors[i].Name == name)
            {
                string[] names = new string[doctors[i].PatientsCount];
                for (int j = 0; j < doctors[i].PatientsCount; j++)
                {
                    names[j] = doctors[i].Patients[j].Name;
                }    
                Array.Sort(names);
                for (int j = 0; j < doctors[i].PatientsCount; j++)
                {
                    Console.WriteLine(names[j]); 
                }    
            }    
        }    
    }
}