using Patterns.Builder.Constants;
using Patterns.Builder.ProductComponents;
using Patterns.Builder.Products;

namespace Patterns.Builder;

public class SteelCarBuilder : ICarBuilder
{
    private Car _car = new Car();
    
    public Task Reset()
    {
        this._car = new Car();
        return Task.CompletedTask;
    }
    
    public async Task BuildDoors()
    {
        var doors = await GetSteelPart(BuilderConstants.Doors);
        await _car.Add(new CarPart(doors));
    }

    public async Task BuildEngine()
    {
        var engine = await GetSteelPart(BuilderConstants.Engine);
        await _car.Add(new CarPart(engine));
    }

    public async Task BuildWheels()
    {
        var wheels = await GetSteelPart(BuilderConstants.Wheels);
        await _car.Add(new CarPart(wheels));
    }

    public async Task BuildWindows()
    {
        var windows = await GetSteelPart(BuilderConstants.Windows);
        await _car.Add(new CarPart(windows));
    }

    public async Task BuildRoof()
    {
        var roof = await GetSteelPart(BuilderConstants.Roof);
        await _car.Add(new CarPart(roof));
    }

    private Task<string> GetSteelPart(string partName) => Task.FromResult($"{BuilderConstants.Steel} {partName}");
    
    public async Task<Car> GetProduct()
    {
        var car = _car;

        await Reset();

        return car;
    }
}