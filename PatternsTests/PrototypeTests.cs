using Patterns.Creational.Prototype;
using Patterns.Creational.Prototype.Resources;

namespace PatternsTests;

public class PrototypeTests
{
    [Fact]
    public async Task Should_create_shallow_copy()
    {
        var car = new Car(DateTime.Now.AddDays(-10))
        {
            Brand = "Volvo",
            Driver = new Driver(1, "Bot"),
            SeatsCount = 5,
            Type = CarType.Jeep

        };
        var shallowCopy = await car.ShallowCopy();
        
        shallowCopy.Age.Days.Should().Be(car.Age.Days);
        shallowCopy.Brand.Should().Be(car.Brand);
        shallowCopy.Type.Should().Be(car.Type);
        shallowCopy.SeatsCount.Should().Be(car.SeatsCount);
        ReferenceEquals(shallowCopy.Driver, car.Driver).Should().BeTrue();
        shallowCopy.Driver.Id.Should().Be(car.Driver.Id);
        shallowCopy.Driver.Name.Should().Be(car.Driver.Name);
    }
    
    [Fact]
    public async Task Should_be_able_to_create_deep_copy()
    {
        var car = new Car(DateTime.Now.AddDays(-10))
        {
            Brand = "Volvo",
            Driver = new Driver(1, "Bot"),
            SeatsCount = 5,
            Type = CarType.Jeep

        };
        var clone = await car.DeepCopy();

        clone.Age.Days.Should().Be(car.Age.Days);
        clone.Brand.Should().Be(car.Brand);
        clone.Type.Should().Be(car.Type);
        clone.SeatsCount.Should().Be(car.SeatsCount);
        ReferenceEquals(clone.Driver, car.Driver).Should().BeFalse();
        clone.Driver.Id.Should().Be(car.Driver.Id);
        clone.Driver.Name.Should().Be(car.Driver.Name);
    }
}