using Patterns.Builder.Constants;
using Patterns.Builder.ProductComponents;
using Patterns.Builder.Products;

namespace Patterns.Builder;

public class IronCarBuilder : ICarBuilder
{
    private Car _car = new Car();
    
    public Task Reset()
    {
        this._car = new Car();
        return Task.CompletedTask;
    }
    
    public async Task BuildDoors()
    {
        var doors = await GetIronPart(BuilderConstants.Doors);
        await _car.Add(new CarPart(doors));
    }

    public async Task BuildEngine()
    {
        var engine = await GetIronPart(BuilderConstants.Engine);
        await _car.Add(new CarPart(engine));
    }

    public async Task BuildWheels()
    {
        var wheels = await GetIronPart(BuilderConstants.Wheels);
        await _car.Add(new CarPart(wheels));
    }

    public async Task BuildWindows()
    {
        var windows = await GetIronPart(BuilderConstants.Windows);
        await _car.Add(new CarPart(windows));
    }

    public async Task BuildRoof()
    {
        var roof = await GetIronPart(BuilderConstants.Roof);
        await _car.Add(new CarPart(roof));
    }

    private Task<string> GetIronPart(string partName) => Task.FromResult($"{BuilderConstants.Iron} {partName}");
    
    public async Task<Car> GetProduct()
    {
        var car = _car;

        await Reset();

        return car;
    }
}