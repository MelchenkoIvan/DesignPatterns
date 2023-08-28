using System.Collections;

namespace Patterns.Behavioral.Iterator;

public class NumberOrderIterator : Iterator
{
    private NumbersCollection _collection;
    private int _position = -1;

    public NumberOrderIterator(NumbersCollection collection)
    {
        _collection = collection;
    }


    public bool MoveNext()
    {
        var updatedPosition = this._position + 1;
        
        if(updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
        {
            _position = updatedPosition;
            return true;
        }

        return false;
        
    }

    public void Reset() => _position = -1;

    public int Key() => _position;

    public object Current() => _collection.GetItems().Order().ToList()[_position];
}