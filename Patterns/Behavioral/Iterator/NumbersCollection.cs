using System.Collections;

namespace Patterns.Behavioral.Iterator;

public class NumbersCollection : IEnumerable
{
    private readonly List<int> _collection = new List<int>();
    
    public List<int> GetItems() => _collection;
    
    public void AddItem(int item) => _collection.Add(item);
    
    public IEnumerator GetEnumerator() => new NumberOrderIterator(this);
}