using Task7;

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

        var excellentStudents = students.Where(s => s.Grades.Contains(6));

        foreach (var student in excellentStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}