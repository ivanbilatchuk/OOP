using System;
using Task4;

class Program
{
    static void Main()
    {
        int capacity = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        Bag bag = new Bag(capacity);

        for (int i = 0; i < input.Length; i += 2)
        {
            string name = input[i];
            int amount = int.Parse(input[i + 1]);
            Item newItem = new Item(name, amount);

            if (newItem.Type == ItemType.Invalid)
            {
                continue;
            }

            if (newItem.Type == ItemType.Gem && bag.GetTotalGems() + amount > bag.GetTotalGold())
            {
                continue;
            }

            if (newItem.Type == ItemType.Cash && bag.GetTotalCash() + amount > bag.GetTotalGems())
            {
                continue;
            }
            bag.Add(newItem);   
        }    
        bag.Print();
    }
}