namespace Task4;

public class Item
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public ItemType Type { get; set; }

    public Item(string name, int amount)
    {
        Name = name;
        Amount = amount;
        Type = DetermineType(name);
    }    
    private ItemType DetermineType(string name)
    {
        string lower = name.ToLower();
        if (lower == "gold")
        {
            return ItemType.Gold;
        }

        if (lower.EndsWith("gem") && name.Length > 3)
        {
            return ItemType.Gem;
        }

        if (name.Length == 3)
        {
            return ItemType.Cash;
        }    
        return ItemType.Invalid;
    }
}