namespace Patterns.Creational.Prototype.Resources;

public class Driver
{
    public Driver(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public int Id { get; private set; }
    
    public string Name { get; set; }
}