using Task1;

public class Family
{
    public Person[] members;
    
    public void AddMember(Person member, int index)
    {
        members[index] = member;
    }

    public Person GetOldestMember()
    {
        Person oldest = members[0];
        for(int i = 1; i < members.Length; i++)
        {
            if (members[i].Age > oldest.Age)
            {
                oldest = members[i];
            }
        }
        return oldest;
    }
}