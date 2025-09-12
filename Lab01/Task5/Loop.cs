using System;

class Loop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Factorial doesn't exist");
        }
        else
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}