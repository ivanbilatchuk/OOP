namespace Task6;

public class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public string Volume { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, int power, string volume = "n/a", string efficiency = "n/a")
    {
        Model = model;
        Power = power;
        Volume = volume;
        Efficiency = efficiency;   
    }    
}