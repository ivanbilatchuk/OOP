using Task2;
using System;
public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
    {
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }

        double actual = liters * 0.95;

        if (fuelQuantity + actual > tankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            return;
        }

        fuelQuantity += actual;
    }
}