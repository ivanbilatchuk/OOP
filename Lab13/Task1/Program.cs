using System;
using Task1;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] data = input.Split(' ');
            students.Add(new Student
            {
                FirstName = data[0],
                LastName = data[1],
                Group = int.Parse(data[2])   
            });
        }    
        var result = students.Where(s => s.Group == 2).OrderBy(s => s.FirstName);
        foreach (var student in result)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }   
    }
}