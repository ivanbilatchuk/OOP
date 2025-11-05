using Task3;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ');
            string name = parts[0];
            int age = int.Parse(parts[1]);
            string town = parts[2];

            people.Add(new Person(name, age, town));
        }

        int n = int.Parse(Console.ReadLine()) - 1;
        Person target = people[n];

        int equalCount = 0;

        foreach (var p in people)
        {
            if (target.CompareTo(p) == 0)
                equalCount++;
        }

        if (equalCount == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int notEqualCount = people.Count - equalCount;
            Console.WriteLine($"{equalCount} {notEqualCount} {people.Count}");
        }
    }
}