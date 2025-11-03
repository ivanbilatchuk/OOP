namespace Task1;

public class ListyIterator<T>
{
    private List<T> items;
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
}