

using Patterns.Behavioral.Mediator.Constants;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Entities;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb;

internal sealed class CarDb
{
    public IEnumerable<Car> Cars;
    
    public CarDb()
    {
        Cars = new List<Car>()
        {
            new Car(1, MediatorConstants.VolvoV40),
            new Car(2, MediatorConstants.VolvoV60)
        };
    }
}