namespace Task2;

public abstract class Vehicle
{
    protected double fuelQuantity;
    protected double fuelConsumption;
    protected double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.tankCapacity = tankCapacity;
        if (fuelQuantity > tankCapacity)
        {
            this.fuelQuantity = 0;
        }
        else
        {
            this.fuelQuantity = fuelQuantity;
        }

        this.fuelConsumption = fuelConsumption;
    }

    public virtual void Drive(double distance)
    {
        double neededFuel = distance * fuelConsumption;
        if (neededFuel <= fuelQuantity)
        {
            fuelQuantity -= neededFuel;
            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} needs refueling");
        }
    }

    public virtual void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }

        if (fuelQuantity + liters > tankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            return;
        }

        fuelQuantity += liters;
    }
    public virtual void DriveEmpty(double distance)
    {
        Drive(distance); 
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {fuelQuantity:F2}";
    }
}