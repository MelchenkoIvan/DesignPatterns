using Patterns.Structural.Proxy;
using Patterns.Structural.Proxy.Constants;

namespace PatternsTests;

public class ProxyTests
{
    [Fact]
    public async Task Service_should_be_fooled()
    {
        ICarService service = new ProxyCarService(new CarService());
        
        var id= await service.GetCarId();

        id.Should().Be(ProxyConstants.CarId);
    }
    
    [Fact]
    public async Task Service_should_work_without_proxy()
    {
        ICarService service = new CarService();
        
        var id= await service.GetCarId();

        id.Should().Be(ProxyConstants.CarId);
    }
}