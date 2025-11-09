class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        Action<string> action = name => Console.WriteLine($"Sir {name}");
        foreach (string name in names)
        {
            action(name);
        }  
    }
}