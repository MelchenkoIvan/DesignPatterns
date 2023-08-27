using Patterns.Creational.Singleton;

namespace PatternsTests;

public class SingletonTests
{
    [Fact]
    public void Instance_should_be_equals()
    {
        var s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();

        s1.Should().Be(s2);
    }
}