namespace Patterns.Factory.Product;

public interface ITransport
{
    public Task<string> Move();
}