using MediatR;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.CarCqrsApplication.Commands.UpdateCar;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.CarCqrsApplication.Queries.GetCar;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs;

public class FakeCarController
{
    private readonly IMediator _mediator;
    
    public FakeCarController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<GetCarQueryResponse> GetCar(int carId)
    {
        var result = await _mediator.Send(new GetCarQuery(carId));
        return result;
    }

    public async Task<UpdateCarCommandResponse> UpdateCar(int carId, string carName)
    {
        var result = await _mediator.Send(new UpdateCarCommand(carId, carName));
        return result;
    }
}