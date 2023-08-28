using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Patterns.Behavioral.Mediator.MediatorWithCqrs;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb;
using Patterns.Behavioral.Mediator.MediatorWithCqrs.FakeDb.Services;

namespace Patterns.Behavioral.Mediator;

public static class MediatorExtensions
{
    public static IServiceCollection AddMediatorWithCqrs(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<FakeCarController>();
        services.AddSingleton<CarDb>();
        return services;
    }
    
}