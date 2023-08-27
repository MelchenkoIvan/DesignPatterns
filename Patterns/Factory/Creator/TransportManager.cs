using Patterns.Factory.Constants;
using Patterns.Factory.Product;

namespace Patterns.Factory.Creator;

public abstract class TransportManager
{
    public abstract Task<ITransport> Create();

    public async Task<TimeSpan> CalculateJourneyTime()
    {
        var startJourneyTime = new DateTime();
        var endJourneyTime = new DateTime().AddDays(FactoryConstants.JourneyLengthsInDays);
        return await Task.FromResult(endJourneyTime - startJourneyTime);
    }
}