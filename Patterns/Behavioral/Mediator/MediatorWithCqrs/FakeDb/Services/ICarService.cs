using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Entities;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Services;

internal interface ICarService
{
    public Task<Car> GetCar(int id);
    
    public Task UpdateCarName(int id, string name);
}