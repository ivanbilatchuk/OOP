namespace Task3;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            string lower = value.ToLower();
            if (lower != "white" && lower != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            string lower = value.ToLower();
            if (lower != "crispy" && lower != "chewy" && lower != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        private set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            weight = value;
        }
    }

    private double FlourModifier()
    {
        if (flourType == "white")
        {
            return 1.5;
        }
        else
        {
            return 1.0;
        }
    }

    public double Calories()
    {
        return 2 * weight * FlourModifier() * BakingTechniqueModifier();
    }

    private double BakingTechniqueModifier()
    {
        string t = bakingTechnique.ToLower();
        if (t == "crispy")
        {
            return 0.9;
        }
        else if (t == "chewy")
        {
            return 1.1;
        }
        else
        {
            return 1.0;
        }
    }
    
}