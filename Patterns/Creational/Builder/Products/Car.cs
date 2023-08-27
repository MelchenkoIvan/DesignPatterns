using System.Text;
using Patterns.Creational.Builder.ProductComponents;

namespace Patterns.Creational.Builder.Products;

public class Car
{
    private List<CarPart> _parts = new();

    public Task Add(CarPart part)
    {
        _parts.Add(part);
        
        return Task.CompletedTask;
    }

    public Task<string> ShowCarComponents()
    {
        var separator = ";";
        var components = new StringBuilder();
        
        foreach (var component in _parts.Select(part => part.Name))
        {
            components.Append(component);
            
            if(!component.Equals(_parts.Last().Name, StringComparison.OrdinalIgnoreCase))
                components.Append(separator);
        }

        return Task.FromResult(components.ToString());
    }
}