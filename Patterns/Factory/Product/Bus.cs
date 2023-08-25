namespace Patterns.Factory.Product;

public class Bus : ITransport
{
    public async Task<string> Move() => await Task.FromResult(FactoryConstants.BusMoving);
}