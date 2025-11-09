class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        Func<int[], int[]> reverse = nums => nums.Reverse().ToArray();
        Predicate<int> exclude = num => num % n != 0;
        numbers = reverse(numbers).Where(x => exclude(x)).ToArray();
        Console.WriteLine(string.Join(" ", numbers));

    }
}