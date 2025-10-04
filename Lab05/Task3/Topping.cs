namespace Task3;

public class Topping
{
    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;   
    }    
    public string Type
    {
        get
        {
            return type;
        }

        private set
        {
            string lower = value.ToLower();
            if (lower != "meat" && lower != "veggies" && lower != "cheese" && lower != "sauce")
            {
                throw new ArgumentException("Invalid type of topping.");
            }
            type = value;
        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }
        private set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException("Topping weight should be in the range [1..50].");
            }
            weight = value;
        }   
    }

    public double Calories()
    {
        return 2 * weight * TypeModifier();   
    }
    private double TypeModifier()
    {
        string t = type.ToLower();
        if (t == "meat")
        {
            return 1.2;
        }
        else if (t == "veggies")
        {
            return 0.8;
        }
        else if (t == "cheese")
        {
            return 1.1;
        }    
        else if (t == "sauce")
        {
            return 0.9;
        }
        else
        {
            return 1.0;
        }   
    }
}