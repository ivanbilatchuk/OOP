namespace Task3;

public abstract class Food
{
    public int Quantity { get; private set; }

    protected Food(int quantity)
    {
        Quantity = quantity;   
    }    
}
public class Vegetable : Food
{
    public Vegetable(int quantity) : base(quantity)
    {
    }
}

public class Fruit : Food
{
    public Fruit(int quantity) : base(quantity)
    {
    }
}

public class Meat : Food
{
    public Meat(int quantity) : base(quantity)
    {
    }
}
public class Seed : Food
{
    public Seed(int quantity) : base(quantity)
    {
    }
}