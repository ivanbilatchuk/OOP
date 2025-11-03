using System.Collections;

namespace Task2;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> items;
    private int index;

    public ListyIterator(List<T> collection)
    {
        if (collection != null)
        {
            this.items = collection;
        }
        else
        {
            this.items = new List<T>();
        }

        this.index = 0;
    }

    public bool Move()
    {
        if (HasNext())
        {
            index++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        return index + 1 < items.Count;
    }

    public void Print()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(items[index]);
    }
    
    public void PrintAll()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(string.Join(" ", items));
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < items.Count; i++)
        {
            yield return items[i];
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}