namespace Task2;

public class Person
{
    private string name;
    private decimal money;
    private Product[] bag;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bag = new Product[0];
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

    public decimal Money
    {
        get
        {
            return money;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative.");   
            }    
            money = value;
        }
    }

    public void BuyProduct(Product product)
    {
        if (Money >= product.Price)
        {
            Money -= product.Price;
            Product[] newBag = new Product[bag.Length + 1];
            for (int i = 0; i < bag.Length; i++)
            {
                newBag[i] = bag[i];
            }    
            newBag[bag.Length - 1] = product;
            bag = newBag;
            Console.WriteLine($"{Name} bought {product.Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}.");       
        }
    }

    public void Print()
    {
        if (bag.Length == 0)
        {
            Console.WriteLine($"{Name} - Nothing bought");
        }    
        Console.WriteLine($"{Name} - ");
        for (int i = 0; i < bag.Length; i++)
        {
            Console.Write(bag[i].Name);
            if (i < bag.Length - 1)
            {
                Console.Write(", "); 
            }    
        }    
        Console.WriteLine();
    }
}