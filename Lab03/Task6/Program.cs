using System;
using Task6;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Engine[] engines = ReadEngines(n);
        Car[] cars = ReadCars(engines);
        PrintCars(cars);   
        
    }

    static Engine[] ReadEngines(int n)
    {
        Engine[] engines = new Engine[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string model = input[0];
            int power = int.Parse(input[1]);
            string volume = "n/a";
            string efficiency = "n/a";
            if (input.Length == 3)
            {
                if (char.IsDigit(input[2][0]))
                {
                    volume = input[2];
                }
                else
                {
                    efficiency = input[2];   
                }
            }    
            else if (input.Length == 4)
            {
                volume = input[2];
                efficiency = input[3];
                
            }
            engines[i] = new Engine(model, power, volume, efficiency);  
        }
        return engines;  
    }

    static Car[] ReadCars(Engine[] engines)
    {
        int m = int.Parse(Console.ReadLine());
        Car[] cars = new Car[m];
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string model = input[0];
            string engineModel = input[1];
            Engine eng = FindEngine(engines, engineModel);
            string weight = "n/a";
            string color = "n/a";
            if (input.Length == 3)
            {
                if (char.IsDigit(input[2][0]))
                {
                    weight = input[2];
                }
                else
                {
                    color = input[2];   
                }
            }    
            else if (input.Length == 4)
            {
                weight = input[2];
                color = input[3];
            }    
            cars[i] = new Car(model, eng, weight, color); 
        }    
        return cars;
    }

    static Engine FindEngine(Engine[] engines, string model)
    {
        for (int i = 0; i < engines.Length; i++)
        {
            if (engines[i].Model == model)
            {
                return engines[i];
            }
        }
        return null;   
    }

    static void PrintCars(Car[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Car car = cars[i];
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"     Power: {car.Engine.Power}");
            Console.WriteLine($"     Volume: {car.Engine.Volume}");
            Console.WriteLine($"     Efficiency: {car.Engine.Efficiency}");
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }    
    }
}