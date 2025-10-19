using System.Collections;

namespace Task8_10;

public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
{
    private List<T> items;

    public CustomList()
    {
        items = new List<T>();
    }

    public void Add(T element)
    {
        items.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= items.Count)
            throw new ArgumentOutOfRangeException("Invalid index!");

        T element = items[index];
        items.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        return items.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        if (index1 < 0 || index1 >= items.Count ||
            index2 < 0 || index2 >= items.Count)
            throw new ArgumentOutOfRangeException("Invalid index!");

        T temp = items[index1];
        items[index1] = items[index2];
        items[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach (T item in items)
        {
            if (item.CompareTo(element) > 0)
                count++;
        }
        return count;
    }

    public T Max()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("List is empty!");

        T max = items[0];
        foreach (T item in items)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }

    public T Min()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("List is empty!");

        T min = items[0];
        foreach (T item in items)
        {
            if (item.CompareTo(min) < 0)
                min = item;
        }
        return min;
    }

    public void Print()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in items)
        {
            yield return item;
        }    
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();   
    }

    public List<T> GetItems()
    {
        return items;   
    }
    
}