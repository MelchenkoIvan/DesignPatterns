using MediatR;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.CarCqrsApplication.Queries.GetCar;

public record GetCarQuery(int CarId) : IRequest<GetCarQueryResponse>;