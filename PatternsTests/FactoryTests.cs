using Patterns.Factory.Creator;
using Patterns.Factory.Product;

namespace PatternsTests;

public class FactoryTests
{
    [Fact]
    public async Task Truck_should_move()
    {
        var truckManager = new TruckManager();
        var transport = await GetTransport(truckManager);
        
        var result = await transport.Move();
        
        result.Should().Be(FactoryConstants.TruckMoving);
    }
    
    [Fact]
    public async Task Bus_should_move()
    {
        var busManager = new BusManager();
        var transport = await GetTransport(busManager);
        
        var result = await transport.Move();
        
        result.Should().Be(FactoryConstants.BusMoving);
    }
    
    [Fact]
    public async Task Juorney()
    {
        var busJourneyTime = await (new BusManager()).CalculateJourneyTime();
        var truckJourneyTime = await (new TruckManager()).CalculateJourneyTime();
        busJourneyTime.Should().Be(truckJourneyTime);
    }

    private async Task<ITransport> GetTransport(TransportManager transportManager) => await transportManager.Create();
    
}