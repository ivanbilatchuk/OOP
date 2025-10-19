namespace Task2;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        fuelConsumption += 1.4;
        base.Drive(distance);
        fuelConsumption -= 1.4;
    }

    public override void DriveEmpty(double distance)
    {
        base.Drive(distance);
    }
}