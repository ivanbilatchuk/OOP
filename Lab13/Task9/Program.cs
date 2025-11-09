using Task9;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string input;
        
        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ');
            string facultyNumber = parts[0];
            List<int> grades = parts.Skip(1).Select(int.Parse).ToList();

            students.Add(new Student(facultyNumber, grades));
        }
        
        var result = students.Where(s => s.FacultyNumber.Length >= 6 && 
                                         (s.FacultyNumber.Substring(4, 2) == "14" || 
                                          s.FacultyNumber.Substring(4, 2) == "15")).Select(s => s.Grades);
        
        foreach (var grades in result)
        {
            Console.WriteLine(string.Join(" ", grades));
        }
    }
}