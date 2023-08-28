using System.Collections;

namespace Patterns.Behavioral.Iterator;

public interface Iterator : IEnumerator
{
    object IEnumerator.Current => this.Current();
    public int Key();
    
    public object Current();
}