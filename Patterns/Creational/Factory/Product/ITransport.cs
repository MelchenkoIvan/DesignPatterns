namespace Patterns.Creational.Factory.Product;

public interface ITransport
{
    public Task<string> Move();
}