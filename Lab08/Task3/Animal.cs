namespace Task3;

public abstract class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int FoodEaten { get; set; }

    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
        FoodEaten = 0;   
    }    
    public abstract void Eat(Food food);
    public abstract void MakeSound();
}
public abstract class Bird : Animal
{
    public double WingSize { get; set; }

    protected Bird(string name, double weight, double wingSize) : base(name, weight)
    {
        WingSize = wingSize;  
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {WingSize}, {WingSize}, {FoodEaten}]";
    }
}

public abstract class Mammal : Animal
{
    public string LivingRegion { get; set; }

    protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
    {
        LivingRegion = livingRegion; 
    }    
}

public abstract class Feline : Mammal
{
    public string Breed { get; set; }

    protected Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
    {
        Breed = breed;
    }    
    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Hoot Hoot");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += food.Quantity * 0.25;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cluck");
    }

    public override void Eat(Food food)
    {
        Weight += food.Quantity * 0.35;
        FoodEaten += food.Quantity;
    }
}

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Squeak");
    }

    public override void Eat(Food food)
    {
        if (food is Vegetable || food is Fruit)
        {
            Weight += food.Quantity * 0.10;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion) { }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += food.Quantity * 0.40;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Eat(Food food)
    {
        if (food is Vegetable || food is Meat)
        {
            Weight += food.Quantity * 0.30;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed) { }

    public override void MakeSound()
    {
        Console.WriteLine("ROAR!!!");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += food.Quantity * 1.00;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}


