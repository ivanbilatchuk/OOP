namespace Task2;

public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }    
    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }    
            name = value;
        }
    }

    public decimal Price
    {
        get
        {
            return price;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative.");   
            }    
            price = value;
        }
    }
}