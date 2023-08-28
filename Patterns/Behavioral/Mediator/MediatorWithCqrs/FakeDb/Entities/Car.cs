namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Entities;

public class Car
{
    public Car(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; private set; }
    
    public string Name { get; set; }
}