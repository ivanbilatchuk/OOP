using System;
using Task2;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        decimal price = decimal.Parse(input[0]);
        int number = int.Parse(input[1]);
        Season season = Enum.Parse<Season>(input[2]);
        DiscountType discount = DiscountType.None;
        if (input.Length == 4)
        {
            discount = Enum.Parse<DiscountType>(input[3]);
        }
        PriceCalculator calculator = new PriceCalculator(price, number, season, discount);
        decimal total = calculator.CalculatePrice();
        Console.WriteLine($"Total price: {total:f2}");   
    }
}