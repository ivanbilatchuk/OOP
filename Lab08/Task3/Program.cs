using System;
using Task3;

class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[50];
        int animalCount = 0;
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] animalInfo = input.Split(' ');
            Animal animal = CreateAnimal(animalInfo);

            string[] foodInfo = Console.ReadLine().Split(' ');
            Food food = CreateFood(foodInfo);

            animal.MakeSound();
            animal.Eat(food);

            if (animalCount < animals.Length)
            {
                animals[animalCount] = animal;
                animalCount++;
            }
        }
        for (int i = 0; i < animalCount; i++)
        {
            Console.WriteLine(animals[i].ToString());
        }
    }
    static Animal CreateAnimal(string[] info)
    {
        string type = info[0];
        string name = info[1];
        double weight = double.Parse(info[2]);

        switch (type)
        {
            case "Owl":
                return new Owl(name, weight, double.Parse(info[3]));
            case "Hen":
                return new Hen(name, weight, double.Parse(info[3]));
            case "Mouse":
                return new Mouse(name, weight, info[3]);
            case "Dog":
                return new Dog(name, weight, info[3]);
            case "Cat":
                return new Cat(name, weight, info[3], info[4]);
            case "Tiger":
                return new Tiger(name, weight, info[3], info[4]);
            default:
                throw new ArgumentException("Invalid animal type!");
        }
    }

    static Food CreateFood(string[] info)
    {
        string type = info[0];
        int quantity = int.Parse(info[1]);

        switch (type)
        {
            case "Vegetable":
                return new Vegetable(quantity);
            case "Fruit":
                return new Fruit(quantity);
            case "Meat":
                return new Meat(quantity);
            case "Seeds":
                return new Seed(quantity);
            default:
                throw new ArgumentException("Invalid food type!");
        }
    }
}