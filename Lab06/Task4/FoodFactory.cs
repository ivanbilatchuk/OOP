namespace Task4;

public class FoodFactory
{
    public Food GetFood(string foodName)
    {
        foodName = foodName.ToLower();
        
        if (foodName == "apple")
        {
            return new Apple();
        }
        else if (foodName == "lembas")
        {
            return new Lembas();
        }
        else if (foodName == "cram")
        {
            return new Cram();
        }
        else if (foodName == "melon")
        {
            return new Melon();
        }    
        else if (foodName == "honeycake")
        {
            return new HoneyCake();
        }
        else if (foodName == "mushrooms")
        {
            return new Mushrooms();
        }
        else
        {
            return new EverythingElse();
        }
    }
}