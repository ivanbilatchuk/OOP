namespace Task4;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            result = char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));
        }

        if (result == 0)
        {
            result = x.Name.CompareTo(y.Name);
            if (result == 0)
            {
                result = x.Age.CompareTo(y.Age);
            }
        }

        return result;
    }
}