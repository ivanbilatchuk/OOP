using Task4;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ');
            students.Add(new Student
            {
                FirstName = parts[0],
                LastName = parts[1]
            });
        }

        var result = students.OrderBy(s => s.LastName).ThenByDescending(s => s.FirstName); 

        foreach (var s in result)
        {
            Console.WriteLine($"{s.FirstName} {s.LastName}");
        }
    }
}