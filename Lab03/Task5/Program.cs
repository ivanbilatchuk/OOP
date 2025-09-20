using System;
using Task5;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Car[] cars = ReadCars(n);
        Run(cars);
        PrintCars(cars);   
    }

    static Car[] ReadCars(int n)
    {
        Car[] cars = new Car[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string model = input[0];
            double fuelAmount = double.Parse(input[1]);
            double fuelConsumption = double.Parse(input[2]);
            cars[i] = new Car(model, fuelAmount, fuelConsumption);   
        }
        return cars;   
    }

    static void Run(Car[] arr)
    {
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] input = command.Split(' ');
            if (input[0] == "Drive")
            {
                string carModel = input[1];
                double km = double.Parse(input[2]);
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Model == carModel)
                    {
                        arr[i].Drive(km);
                        break;
                    }
                }
            }    
        }    
    }
    
    
    static void PrintCars(Car[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].Print();
        }    
    }
}