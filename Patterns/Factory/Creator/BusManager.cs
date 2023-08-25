using Patterns.Factory.Product;

namespace Patterns.Factory.Creator;

public class BusManager : TransportManager
{
    public override async Task<ITransport> Create() => await Task.FromResult(new Bus());
}