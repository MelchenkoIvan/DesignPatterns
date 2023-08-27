using Patterns.Creational.Prototype.Resources;

namespace Patterns.Creational.Prototype;

public class Car : ICloneable<Car>
{
    private readonly DateTime _created;

    public Car(DateTime creationDate)
    {
        _created = creationDate;
    }

    public string Brand { get; set; } = null!;

    public int SeatsCount { get; set; }
    
    public Driver Driver { get; set; } = null!;

    public CarType Type { get; set; }

    public TimeSpan Age => DateTime.Now - _created;
    

    public Task<Car> ShallowCopy()
    {
        var shallowCopy = (Car)this.MemberwiseClone();
        return Task.FromResult(shallowCopy);
    }

    public Task<Car> DeepCopy()
    {
        var clone = (Car)this.MemberwiseClone();
        clone.Driver = new Driver(Driver.Id, Driver.Name);

        return Task.FromResult(clone);
    }
}