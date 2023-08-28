using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Entities;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Services;

internal class CarService : ICarService
{
    private readonly CarDb _carDb;

    public CarService(CarDb carDb)
    {
        _carDb = carDb;
    }

    public Task<Car> GetCar(int id)
    {
        try
        {
            var result = _carDb.Cars.Single(x => x.Id == id);
            return Task.FromResult(result);
        }
        catch (Exception e)
        {
            throw new Exception($"Can not get car with id: {id}", e);
        }
    }

    public Task UpdateCarName(int id, string name)
    {
        try
        {
            var result = _carDb.Cars.Single(x => x.Id == id);
            result.Name = name;
            return Task.CompletedTask;
        }
        catch (Exception e)
        {
            throw new Exception($"Can not update car name {name} for car with id: {id}", e);
        }
    }
}