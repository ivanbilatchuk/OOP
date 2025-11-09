class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Func<int[], int[]> add = nums => nums.Select(n => n + 1).ToArray();
        Func<int[], int[]> multiply = nums => nums.Select(n => n * 2).ToArray();
        Func<int[], int[]> subtract = nums => nums.Select(n => n - 1).ToArray();
        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            if (command == "add")
            {
                numbers = add(numbers);
            }    
            else if (command == "multiply")
            {
                numbers = multiply(numbers);
            }    
            else if (command == "subtract")
            {
                numbers = subtract(numbers);
            }    
            else if (command == "print")
            {
                Console.WriteLine(string.Join(" ", numbers));
            }    
        }    
    }
}
