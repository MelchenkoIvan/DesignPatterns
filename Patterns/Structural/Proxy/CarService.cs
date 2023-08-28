using Patterns.Structural.Proxy.Constants;

namespace Patterns.Structural.Proxy;

public class CarService : ICarService
{
    public Task<int> GetCarId()
    {
        return Task.FromResult(ProxyConstants.CarId);
    }
}