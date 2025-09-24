namespace Task2;

public class PriceCalculator
{
    public decimal PricePerDay { get; set; }
    public int Days { get; set; }
    public Season Season { get; set; }
    public DiscountType DiscountType { get; set; }

    public PriceCalculator(decimal pricePerDay, int days, Season season, DiscountType discountType)
    {
        PricePerDay = pricePerDay;
        Days = days;
        Season = season;
        DiscountType = discountType; 
    }

    public decimal CalculatePrice()
    {
        decimal total = PricePerDay * Days * (int)Season;
        if (DiscountType == DiscountType.VIP)
        {
            total *= 0.8m;
        }    
        else if (DiscountType == DiscountType.SecondVisit)
        {
            total *= 0.9m;
        }
        return total;
    }
}