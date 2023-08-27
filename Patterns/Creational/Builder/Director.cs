namespace Patterns.Creational.Builder;

public class Director
{
    private ICarBuilder _builder = null!;
    
    public required ICarBuilder Builder
    {
        set => _builder = value;
    }


    public async Task BuildStandardCar()
    {
        await _builder.BuildWheels();
        await _builder.BuildDoors();
        await _builder.BuildEngine();
        await _builder.BuildWindows();
        await _builder.BuildRoof();
    }

    public async Task BuildCabriolet()
    {
        await _builder.BuildWheels();
        await _builder.BuildDoors();
        await _builder.BuildEngine();
        await _builder.BuildWindows();
    }
}

public static class DirectorExtensions
{
    public static void ChangeBuilder(this Director director, ICarBuilder builder)
    {
        director.Builder = builder;
    }
}