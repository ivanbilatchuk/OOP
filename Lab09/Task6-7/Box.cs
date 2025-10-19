namespace Task6_7;

public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
{
    private T value;
    public Box(T value) { this.value = value; }

    public override string ToString()
    {
        return $"{value.GetType().FullName}: {value}";
    }

    public int CompareTo(Box<T> other)
    {
        return value.CompareTo(other.value);
    }
}