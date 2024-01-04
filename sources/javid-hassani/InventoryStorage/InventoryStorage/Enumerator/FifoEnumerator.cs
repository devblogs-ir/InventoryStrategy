using System.Collections;

namespace InventoryStorage.Enumerator;
public class FifoEnumerato<T> : IEnumerator<T> where T : class
{
    private readonly List<T> _values;
    private int _index;
    public FifoEnumerato(List<T> values)
    {
        _values = values;
        _index = -1;
    }

    public T Current => _values[_index];

    object IEnumerator.Current => _values[_index];

    public void Dispose()
    {
        _values.Clear();
        _index = -1;
    }

    public bool MoveNext()
    {
        if (_values.Count - 1 > _index)
        {
            _index++;
            return true;
        }

        return false;
    }
    public void Reset()
    {
        _index = -1;
    }
}
