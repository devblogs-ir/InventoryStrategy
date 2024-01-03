using System.Collections;

namespace InventoryStrategy.Enumerators;
//
// Summary:
//     An implementation for IEnumerator<T> which iterates the list in LIFO manner
public class LIFOEnumerator<T> : IEnumerator<T>
{
    private readonly List<T> _list;
    private int _index;
    private T? _current;
    private bool _isDisposed;

    public LIFOEnumerator(List<T> list)
    {
        _list = list;
        _index = list.Count - 1;
        _current = default;
        _isDisposed = false;
    }

    public T Current
    {
        get { return _current; }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        if (!_isDisposed)
        {
            _list.Clear();
            _isDisposed = true;
        }
    }
    public bool MoveNext()
    {
        List<T> localList = _list;
        if (_index >= 0)
        {
            _current = localList[_index];
            _index--;
            return true;
        }
        return false;
    }
    public void Reset()
    {
        _index = _list.Count - 1;
        _current = default;
    }
}
