

using Patterns.Creational.Builder;
using Patterns.Creational.Builder.Constants;

namespace PatternsTests;

public class BuilderTests
{
    [Fact]
    public async Task Should_Build_Iron_Standard_Car()
    {
        
        var ironCarBuilder = new IronCarBuilder();
        var director = new Director()
        {
            Builder = ironCarBuilder
        };
        await director.BuildStandardCar();
        var car = await (await ironCarBuilder.GetProduct()).ShowCarComponents();
        
        car.Should().Contain(BuilderConstants.Iron);
        car.Should().NotContain(BuilderConstants.Steel);
        car.Should().Contain(BuilderConstants.Roof);
    }
    
    [Fact]
    public async Task Should_Build_Steel_Cabriolet()
    {
        var steelCarBuilder = new SteelCarBuilder();
        var director = new Director()
        {
            Builder = steelCarBuilder
        };
        await director.BuildCabriolet();
        var car = await (await steelCarBuilder.GetProduct()).ShowCarComponents();
        
        car.Should().NotContain(BuilderConstants.Iron);
        car.Should().Contain(BuilderConstants.Steel);
        car.Should().NotContain(BuilderConstants.Roof);
    }
    
    [Fact]
    public async Task Should_Build_Iron_Cabriolet_With_Steel_Engine()
    {
        var ironCarBuilder = new IronCarBuilder();
        var steelCarBuilder = new SteelCarBuilder();
        
        await ironCarBuilder.BuildDoors();
        await ironCarBuilder.BuildWindows();
        await ironCarBuilder.BuildWheels();
        await steelCarBuilder.BuildEngine();

        var carFirstPart = await ironCarBuilder.GetProduct();
        var carSecondPart = await steelCarBuilder.GetProduct();

        var carComponents = $"{await carFirstPart.ShowCarComponents()};{await carSecondPart.ShowCarComponents()}";

        carComponents.Should().Contain(BuilderConstants.Iron);
        carComponents.Should().Contain(BuilderConstants.Steel);
    }
}