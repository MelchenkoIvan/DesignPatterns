namespace Patterns.Creational.Singleton;

public sealed class Singleton
{
    private Singleton() { }
    private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() => new Singleton());

    public static Singleton GetInstance() => Instance.Value;
}