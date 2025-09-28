namespace Task3;

public class Pizza
{
    private string name;
    private Dough dough;
    private Topping[] toppings;
    private int toppingCount;

    public Pizza(string name)
    {
        Name = name;
        toppings = new Topping[10];
        toppingCount = 0;
    }
    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Name cannot be empty and cannot be more than 15 characters.");   
            }    
            name = value;
        }
    }

    public void SetDough(Dough dough)
    {
        this.dough = dough;
    }
    public void AddTopping(Topping topping)
    {
        if (toppingCount >= 10)
        {
            throw new ArgumentException("Number of toppings should be in the range [0..10].");
        }
        toppings[toppingCount++] = topping;
    }

    public double TotalCalories()
    {
        double total = dough.Calories();
        for (int i = 0; i < toppingCount; i++)
        {
            total += toppings[i].Calories();
        }

        return total;
    }
}