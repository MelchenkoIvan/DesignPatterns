namespace Patterns.Creational.Builder.ProductComponents;

public class CarPart
{
    public CarPart(string name, string description = null)
    {
        Name = name;
        Description = description;
    }
    public string Name { get; private set; }
    
    public string? Description { get; private set; }
}