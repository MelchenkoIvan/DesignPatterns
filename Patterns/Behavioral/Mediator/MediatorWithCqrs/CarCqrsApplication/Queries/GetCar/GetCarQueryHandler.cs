using MediatR;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Services;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.CarCqrsApplication.Queries.GetCar;

internal class GetCarQueryHandler : IRequestHandler<GetCarQuery, GetCarQueryResponse>
{
    private readonly ICarService _carService;
    
    public GetCarQueryHandler(ICarService carService)
    {
        _carService = carService;
    }
    
    public async Task<GetCarQueryResponse> Handle(GetCarQuery request, CancellationToken cancellationToken)
    {
        var car = await _carService.GetCar(request.CarId);
        return new GetCarQueryResponse(car);
    }
}