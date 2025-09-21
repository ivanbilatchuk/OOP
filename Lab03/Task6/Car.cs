namespace Task6;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public string Weight { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine, string weight = "n/a", string color = "n/a")
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;  
    }    
}