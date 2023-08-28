using MediatR;

namespace Patterns.Behavioral.Mediator.MediatorWithCqrs.CarCqrsApplication.Commands.UpdateCar;

public record UpdateCarCommand(int CarId, string CarName) : IRequest<UpdateCarCommandResponse>;