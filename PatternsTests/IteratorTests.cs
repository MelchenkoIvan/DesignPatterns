using Patterns.Behavioral.Iterator;

namespace PatternsTests;

public class IteratorTests
{
    [Fact]
    public void Should_return_collection_in_number_order()
    {
        var verificationList = new List<int>() { 1, 2, 3, 3, 5 };
        var collection = new NumbersCollection();
        
        collection.AddItem(1);
        collection.AddItem(3);
        collection.AddItem(5);
        collection.AddItem(2);
        collection.AddItem(3);

        var list = collection.Cast<int>().ToList();

        for (var i = 0; i < verificationList.Count; i++)
        {
            list[i].Should().Be(verificationList[i]);
        }
    }
}