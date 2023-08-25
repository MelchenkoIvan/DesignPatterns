using Patterns.Factory.Product;

namespace Patterns.Factory.Creator;

public class TruckManager : TransportManager
{
    public override async Task<ITransport> Create() => await Task.FromResult(new Truck());
}