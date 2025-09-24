using System;
using Task2;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        decimal price = decimal.Parse(input[0]);
        int number = int.Parse(input[1]);
        Season season = ParseSeason(input[2]);
        DiscountType discount = DiscountType.None;
        if (input.Length == 4)
        {
            discount = ParseDiscount(input[3]);
        }
        PriceCalculator calculator = new PriceCalculator(price, number, season, discount);
        decimal total = calculator.CalculatePrice();
        Console.WriteLine($"Total price: {total:f2}");   
    }

    static Season ParseSeason(string season)
    {
        switch (season.ToLower())
        {
            case "spring":
                return Season.Spring;
            
            case "summer":
                return Season.Summer;
            case "autumn":
                return Season.Autumn;
            case "winter":
                return Season.Winter;
            default:
                Console.WriteLine("Invalid season. Return Winter by default");
                return Season.Winter; 
        }
    }

    static DiscountType ParseDiscount(string discount)
    {
        switch (discount.ToLower())
        {
            case "none" :
                return DiscountType.None;
            case "secondvisit" :
               return  DiscountType.SecondVisit;
            case "vip" :
                return DiscountType.VIP;
            default:
                Console.WriteLine("Invalid discount.");
                return DiscountType.None;  
        }
    }
    
}