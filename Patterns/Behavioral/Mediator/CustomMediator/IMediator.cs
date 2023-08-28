namespace Patterns.Behavioral.Mediator.CustomMediator;

public interface IMediator
{
    public Task Notify(object sender);
}