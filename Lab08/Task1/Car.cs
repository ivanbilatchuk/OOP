namespace Task1;

class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 0.9)
    {
    }
    public override void Drive(double distance)
    {
        double neededFuel = distance * fuelConsumption;
        if (neededFuel <= fuelQuantity)
        {
            fuelQuantity -= neededFuel;
            Console.WriteLine($"Car travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Car needs refueling");
        }
    }
    public override void Refuel(double liters)
    {
        fuelQuantity += liters;
    }

}