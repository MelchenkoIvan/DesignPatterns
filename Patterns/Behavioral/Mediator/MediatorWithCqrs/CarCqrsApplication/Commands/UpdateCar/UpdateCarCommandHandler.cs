using MediatR;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Services;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.CarCqrsApplication.Commands.UpdateCar;

internal class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, UpdateCarCommandResponse>
{
    private readonly ICarService _carService;

    public UpdateCarCommandHandler(ICarService carService)
    {
        _carService = carService;
    }
    
    public async Task<UpdateCarCommandResponse> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
    {
        await _carService.UpdateCarName(request.CarId, request.CarName);
        var car = await _carService.GetCar(request.CarId);
        return new UpdateCarCommandResponse(car);
    }
}