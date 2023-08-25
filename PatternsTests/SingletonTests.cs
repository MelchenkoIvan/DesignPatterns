namespace PatternsTests;

public class SingletonTests
{
    [Fact]
    public void Instance_should_be_equals()
    {
        var s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();
        
        Assert.Equal(s1,s2);
    }
}