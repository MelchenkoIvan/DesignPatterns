namespace Patterns.Creational.Builder;

public interface ICarBuilder
{
    Task BuildDoors();
    
    Task BuildEngine();
    
    Task BuildWheels();
    
    Task BuildWindows();

    Task BuildRoof();
}