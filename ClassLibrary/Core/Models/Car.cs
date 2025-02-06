namespace ClassLibrary.Core.Models;

public class Car
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }

    public Car(string name, string model, string type, string color)
    {
        Name = name;
        Model = model;
        Type = type;
        Color = color;
    }
}
