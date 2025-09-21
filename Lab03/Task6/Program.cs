using System;
using Task6;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Engine[] engines = ReadEngines(n);
        
    }

    static Engine[] ReadEngines()
    {
        int n = int.Parse(Console.ReadLine());
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
        
    }
}