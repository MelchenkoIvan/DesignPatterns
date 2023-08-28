using Microsoft.Extensions.DependencyInjection;
using Patterns.Behavioral.Mediator;
using Patterns.Behavioral.Mediator.Constants;
using Patterns.Behavioral.Mediator.MediatorWithCqrs;

namespace PatternsTests;

public class MediatorWithCqrsTests
{
    private readonly FakeCarController _controller;
    
    public MediatorWithCqrsTests()
    {
        var serviceProvider = new ServiceCollection()
            .AddMediatorWithCqrs()
            .BuildServiceProvider();
        
        var controller = (FakeCarController)serviceProvider.GetService(typeof(FakeCarController));
        _controller = controller;
    }
    
    [Fact]
    public async Task Should_get_car()
    {
        var carId = 1;

        var response = await _controller.GetCar(carId);

        response.Car.Id.Should().Be(carId);
    }
    
    [Fact]
    public async Task Should_update_car()
    {
        var carId = 1;

        var prevCar = (await _controller.GetCar(carId)).Car;

        var car = (await _controller.UpdateCar(carId, MediatorConstants.VolvoV60)).Car;
        
        car.Name.Should().Be(MediatorConstants.VolvoV60);
        prevCar.Name.Should().Be(car.Name);
    }
}