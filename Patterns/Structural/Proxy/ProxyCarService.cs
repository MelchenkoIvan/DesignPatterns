namespace Patterns.Structural.Proxy;

public class ProxyCarService : ICarService
{
    private readonly CarService _carService;
        
    public ProxyCarService(CarService carService)
    {
        _carService = carService;
    }
    
    public async Task<int> GetCarId()
    {
        if (!await CurrentUserHasAccess())
            throw new UnauthorizedAccessException();

        return await _carService.GetCarId();
    }

    private Task<bool> CurrentUserHasAccess() => Task.FromResult(true);
}