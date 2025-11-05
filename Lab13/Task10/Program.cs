using Task10;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        string input;
        
        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ');
            string name = parts[0] + " " + parts[1];
            int group = int.Parse(parts[2]);

            people.Add(new Person(name, group));
        }
        
        var grouped = people
            .GroupBy(p => p.Group)
            .OrderBy(g => g.Key);
        foreach (var group in grouped)
        {
            string students = string.Join(", ", group.Select(p => p.Name));
            Console.WriteLine($"{group.Key} - {students}");
        }
    }
}