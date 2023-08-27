using Patterns.Creational.Factory.Product;

namespace Patterns.Creational.Factory.Creator;

public class BusManager : TransportManager
{
    public override async Task<ITransport> Create() => await Task.FromResult(new Bus());
}