using Patterns.Factory.Constants;
using Patterns.Factory.Creator;
using Patterns.Factory.Product;

namespace PatternsTests;

public class FactoryTests
{
    [Fact]
    public async Task Truck_should_be_move()
    {
        var truckManager = new TruckManager();
        var transport = await GetTransport(truckManager);
        
        var result = await transport.Move();
        
        result.Should().Be(FactoryConstants.TruckMoving);
    }
    
    [Fact]
    public async Task Bus_should_be_move()
    {
        var busManager = new BusManager();
        var transport = await GetTransport(busManager);
        
        var result = await transport.Move();
        
        result.Should().Be(FactoryConstants.BusMoving);
    }
    
    [Fact]
    public async Task Journey_time_for_transport_should_be_the_same()
    {
        var busJourneyTime = await (new BusManager()).CalculateJourneyTime();
        var truckJourneyTime = await (new TruckManager()).CalculateJourneyTime();
        busJourneyTime.Should().Be(truckJourneyTime);
    }

    private async Task<ITransport> GetTransport(TransportManager transportManager) => await transportManager.Create();
    
}