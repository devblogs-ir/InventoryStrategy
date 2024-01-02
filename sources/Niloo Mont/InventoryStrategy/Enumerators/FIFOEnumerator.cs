using System.Collections;

namespace InventoryStrategy.Enumerators;

public class FIFOEnumerator<T> : IEnumerator<T>
{
    private readonly List<T> _list;
    private int _index;
    private T? _current;
    private bool _isDisposed;
    public FIFOEnumerator(List<T> list)
    {
        _list = list;
        _index = 0;
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
        if ((uint)_index < (uint)_list.Count)
        {
            _current = localList[_index];
            _index++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _index = 0;
        _current = default;
    }
}
