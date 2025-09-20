namespace Task5;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumption { get; set; }
    public double Distance { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumption = fuelConsumption;
        Distance = 0;   
    }

    public void Drive(double kilometers)
    {
        double fuelNeeded = kilometers * FuelConsumption;
        if (fuelNeeded <= FuelAmount)
        {
            FuelAmount -= fuelNeeded;
            Distance += kilometers;
        }
        else
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }   
    }

    public void Print()
    {
        Console.WriteLine($"{Model} {FuelAmount:f2} {Distance}");
    }
}