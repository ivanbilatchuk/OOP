namespace Task4;

public class MoodFactory
{
    public Mood GetMood(int happiness)
    {
        if (happiness < -5)
        {
            return new Angry();
        }    
        else if (happiness <= 0)
        {
            return new Sad();
        }    
        else if (happiness <= 15)
        {
            return new Happy();
        }
        else
        {
            return new JavaScript();
        }
    }
}