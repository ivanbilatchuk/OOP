using Task2;
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
            });
        }
        var result = students.Where(s => string.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0);
        foreach (var student in result)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }  
    }
}