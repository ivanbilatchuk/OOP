namespace Task4;

public class Bag
{
    public int Capacity { get; set; }
    public int CurrentWeight { get; set; }
    public Item[] Items { get; set; }
    public int ItemsCount { get; set; }

    public Bag(int capacity)
    {
        Capacity = capacity;
        CurrentWeight = 0;
        Items = new Item[100];
        ItemsCount = 0;
    }

    public bool CanAdd(Item item)
    {
        return CurrentWeight + item.Amount <= Capacity;
    }

    public void Add(Item item)
    {
        if (!CanAdd(item))
        {
            return;
        }

        for (int i = 0; i < ItemsCount; i++)
        {
            if (Items[i].Name.ToLower() == item.Name.ToLower())
            {
                Items[i].Amount += item.Amount;
                CurrentWeight += item.Amount;
                return;   
            }    
        }

        if (ItemsCount == Items.Length)
        {
            Item[] bigger = new Item[Items.Length * 2];
            Array.Copy(Items, bigger, Items.Length);
            Items = bigger;
        }    
        Items[ItemsCount++] = item;
        CurrentWeight += item.Amount;   
    }

    public int GetTotalGold()
    {
        int total = 0;
        for (int i = 0; i < ItemsCount; i++)
        {
            if (Items[i].Type == ItemType.Gold)
            {
                total += Items[i].Amount;
            }    
        }    
        return total;
    }
    public int GetTotalGems()
    {
        int total = 0;
        for (int i = 0; i < ItemsCount; i++)
        {
            if (Items[i].Type == ItemType.Gem)
            {
                total += Items[i].Amount;
            }    
        }    
        return total;   
    }
    public int GetTotalCash()
    {
        int total = 0;
        for (int i = 0; i < ItemsCount; i++)
        {
            if (Items[i].Type == ItemType.Cash)
            {
                total += Items[i].Amount;
            }    
        }    
        return total;  
    }

    public void Print()
    {
        Item[] copy = new Item[ItemsCount];
        Array.Copy(Items, copy, ItemsCount);
        BubbleSort(copy, copy.Length);
        ItemType currentType = ItemType.Invalid;
        int typeTotal = 0;
        for (int i = 0; i < copy.Length; i++)
        {
            if (copy[i].Type != currentType)
            {
                if (i > 0)
                {
                    Console.WriteLine();
                }
                currentType = copy[i].Type;
                typeTotal = GetTypeTotal(currentType);
                Console.WriteLine($"<{currentType}>: {typeTotal}");
            }
            Console.WriteLine($"##{copy[i].Name} - {copy[i].Amount}");   
        }    

    }

    private int GetTypeTotal(ItemType type)
    {
        if (type == ItemType.Gold)
        {
            return GetTotalGold();
        }
        if (type == ItemType.Gem)
        {
            return GetTotalGems();
        }

        if (type == ItemType.Cash)
        {
            return GetTotalCash();
        }
        return 0;
    }

    private int CompareItems(Item a, Item b)
    {
        int totalA = GetTypeTotal(a.Type);
        int totalB = GetTypeTotal(b.Type);
        int cmp = totalB.CompareTo(totalA);
        if (cmp != 0)
        {
            return cmp;
        }    
        cmp = string.Compare(b.Name.ToLower(), a.Name.ToLower());
        if (cmp != 0)
        {
            return cmp;
        }    
        return a.Amount.CompareTo(b.Amount);
    }

    private void BubbleSort(Item[] arr, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (CompareItems(arr[j], arr[j + 1]) > 0)
                {
                    Item temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }    
            }    
        }    
    }

}