namespace Task4;

public abstract class Mood
{
    public  abstract string Name { get; }
}

public class Angry : Mood
{
    public override string Name
    {
        get
        {
            return "Angry";
        }
    }
}

public class Sad : Mood
{
    public override string Name
    {
        get
        {
            return "Sad";
        }
    }
}

public class Happy : Mood
{
    public override string Name
    {
        get
        {
            return "Happy";
        }
    }
}
public class JavaScript : Mood
{
    public override string Name
    {
        get
        {
            return "JavaScript";
        }
    }
}