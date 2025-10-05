namespace Task4;

public abstract class Food
{
    public abstract int HappinessPoints { get;  }
}
public class Cram : Food
{
    public override int HappinessPoints
    {
        get
        {
            return 2;
        }
    }
}

public class Lembas : Food
{
    public override int HappinessPoints
    {
        get
        {
            return 3;
        }
    }
}
public class Apple : Food
{
    public override int HappinessPoints
    {
        get
        {
            return 1;
        }
    }
}

public class Melon : Food
{
    public override int HappinessPoints
    {
        get
        {
            return 1;
        }
    }
}
public class HoneyCake : Food
{
    public override int HappinessPoints
    {
        get
        {
            return 5;
        }
    }
}
public class Mushrooms : Food
{
    public override int HappinessPoints
    {
        get
        {
            return -10;
        }
    }
}
public class EverythingElse : Food
{
    public override int HappinessPoints
    {
        get
        {
            return -1;
        }
    }
}