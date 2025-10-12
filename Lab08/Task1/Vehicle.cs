using System;

abstract class Vehicle
{
    protected double fuelQuantity;
    protected double fuelConsumption;

    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumption = fuelConsumption;
    }    
    public abstract void Drive(double distance);
    public abstract void Refuel(double liters);

    public double FuelQuantity
    {
        get
        {
            return fuelQuantity;
        }
        set
        {
            fuelQuantity = value;
        }
    }
}