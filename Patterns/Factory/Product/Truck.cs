namespace Patterns.Factory.Product;

public class Truck : ITransport
{
    public async Task<string> Move() => await Task.FromResult(FactoryConstants.TruckMoving);
}