using System;
using System.Data;
using Task3;

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Output")
            {
                break;
            }

            string[] parts = input.Split(' ');
            string department = parts[0];
            string doctor = parts[1] + " " + parts[2];
            string patient = parts[3];
            hospital.AddPatient(department, doctor, patient);
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            string[] parts = input.Split(' ');
            if (parts.Length == 1)
            {
                hospital.PrintDepartment(parts[0]);
            }    
            else if (parts.Length == 2 && int.TryParse(parts[1], out int room))
            {
                hospital.PrintDepRoom(parts[0], room);
            }
            else if (parts.Length == 2)
            {
                hospital.PrintDoctor(input);
            }
        }    
    }
}