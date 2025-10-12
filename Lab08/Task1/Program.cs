using System;
using Task1;

class Program
{
    static void Main()
    {
        string[] carInfo = Console.ReadLine().Split();
        string[] truckInfo = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];
            string type = command[1];
            double value = double.Parse(command[2]);
            Vehicle current;
            if (type == "Car")
            {
                current = car;
            }
            else
            {
                current = truck;
            }

            if (action == "Drive")
            {
                current.Drive(value);
            }
            else if (action == "Refuel")
            {
                current.Refuel(value);
            }    
        }    
        Console.WriteLine($"Car: {car.FuelQuantity:F2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
    }
}