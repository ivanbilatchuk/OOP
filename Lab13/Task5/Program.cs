using Task5;

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
            string email = parts[2];

            students.Add(new Student(firstName, lastName, email));
        }

        var result = students.Where(s => s.Email.EndsWith("@gmail.com"));

        foreach (var student in result)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}