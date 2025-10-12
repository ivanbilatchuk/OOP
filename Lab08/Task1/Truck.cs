namespace Task1;

class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption + 1.6)
    {
    }

    public override void Drive(double distance)
    {
        double neededFuel = distance * fuelConsumption;
        if (neededFuel <= fuelQuantity)
        {
            fuelQuantity -= neededFuel;
            Console.WriteLine($"Truck travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Truck needs refueling");
        }
    }

    public override void Refuel(double liters)
    {
        fuelQuantity += liters * 0.95;
    }
}