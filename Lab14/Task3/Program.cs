class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Func<int[], int> func = nums =>
        {
            int min = nums[0];
            foreach (int n in nums)
            {
                if (n < min)
                {
                    min = n;
                }
            }
            return min;
        };
        Console.WriteLine(func(numbers)); 

    }
}