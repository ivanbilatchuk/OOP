using System;
using Task2;

class Program
{
    static void Main()
    {
        string[] carInfo = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

        string[] truckInfo = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

        string[] busInfo = Console.ReadLine().Split();
        Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];
            string type = command[1];
            double value = double.Parse(command[2]);
            if (action == "Drive")
            {
                double distance = double.Parse(command[2]);
                if (type == "Car")
                {
                    car.Drive(distance);
                }
                else if (type == "Truck")
                {
                    truck.Drive(distance);
                }
                else if (type == "Bus")
                {
                    bus.Drive(distance);
                }
            }
            else if (action == "DriveEmpty")
            {
                if (type == "Bus")
                {
                    bus.DriveEmpty(value);
                }
            }
            else if (action == "Refuel")
            {
                if (type == "Car")
                {
                    car.Refuel(value);
                }
                else if (type == "Truck")
                {
                    truck.Refuel(value);
                }
                else if (type == "Bus")
                {
                    bus.Refuel(value);
                }
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}