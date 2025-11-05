using Task3;
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
                LastName = parts[1],
                Age = int.Parse(parts[2])
            });
        }
        
        var result = students.Where(s => s.Age >= 18 && s.Age <= 24).Select(s => new
        {
            s.FirstName,
            s.LastName, 
            s.Age
        });
        foreach (var st in result)
        {
            Console.WriteLine($"{st.FirstName} {st.LastName} {st.Age}");
        }
    }
}