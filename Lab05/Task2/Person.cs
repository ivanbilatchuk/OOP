namespace Task2;

public class Person
{
    private string name;
    private decimal money;
    private Product[] bag;
    private int count;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bag = new Product[20];
        count = 0;
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
            if (count >= bag.Length)
            {
                Console.WriteLine($"{Name} cannot buy more products (bag is full).");
            }
            else
            {
                bag[count] = product;
                Money -= product.Price;
                count++;
                Console.WriteLine($"{Name} bought {product.Name}.");
            }   
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}.");       
        }
    }

    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine($"{Name} - Nothing bought");
        }
        else
        {
            Console.Write($"{Name} - ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(bag[i].Name);
                if (i < count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}