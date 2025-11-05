using Task4;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string name = parts[0];
            int age = int.Parse(parts[1]);

            people.Add(new Person(name, age));
        }
        List<Person> sortedByName = new List<Person>(people);
        List<Person> sortedByAge = new List<Person>(people);
        sortedByName.Sort(new NameComparator());
        sortedByAge.Sort(new AgeComparator());
        foreach (var person in sortedByName)
        {
            Console.WriteLine(person);
        }

        foreach (var person in sortedByAge)
        {
            Console.WriteLine(person);
        }
    }
}