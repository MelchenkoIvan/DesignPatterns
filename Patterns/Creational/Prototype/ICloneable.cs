namespace Patterns.Creational.Prototype;

public interface ICloneable<T>
{
    public Task<T> ShallowCopy();
    
    public Task<T> DeepCopy();
}