using Patterns.Creational.Factory.Product;

namespace Patterns.Creational.Factory.Creator;

public class TruckManager : TransportManager
{
    public override async Task<ITransport> Create() => await Task.FromResult(new Truck());
}