using Task8;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string input;
        
        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ');
            string firstName = parts[0];
            string lastName = parts[1];
            List<int> grades = parts.Skip(2).Select(int.Parse).ToList();

            students.Add(new Student(firstName, lastName, grades));
        }
        
        var weakStudents = students
            .Where(s => s.Grades.Count(g => g <= 3) >= 2);
        
        foreach (var student in weakStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}