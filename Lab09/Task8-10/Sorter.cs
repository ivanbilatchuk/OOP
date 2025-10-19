namespace Task8_10;

public class Sorter
{
    public static void Sort<T>(CustomList<T> list) where T : IComparable<T>
    {
        list.GetItems().Sort();
    }
}