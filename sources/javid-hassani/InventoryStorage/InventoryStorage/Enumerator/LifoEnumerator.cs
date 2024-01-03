using System.Collections;

namespace InventoryStorage.Enumerator;
public class LifoEnumerator<T> : IEnumerator<T> where T : class
{
    private List<T> _values;
    private int _index;
    public LifoEnumerator(List<T> values)
    {
        _values = values;
        _index = _values.Count;
    }
    public T Current => _values[_index];

    object IEnumerator.Current => _values[_index];

    public void Dispose()
    {
        _values.Clear();
    }

    public bool MoveNext()
    {
        if (_index > 0)
        {
            _index--;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _index = _values.Count - 1;
    }
}
