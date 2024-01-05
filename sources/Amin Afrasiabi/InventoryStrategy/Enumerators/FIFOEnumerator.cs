using System.Collections;

namespace InventoryStrategy.Enumerators;

public class FIFOEnumerator<T> : IEnumerator<T>
{
    private readonly List<T> _list;
    private int _index;
    private int _size;
    private bool _disposed;
    public FIFOEnumerator(List<T> list)
    {
        ArgumentNullException.ThrowIfNull(nameof(list));
        _list = list;
        _size = _list.Count;
        _index = -1;
        _disposed = false;
    }

    public T Current => _list.ElementAt(_index);

    object IEnumerator.Current => Current ?? throw new ArgumentNullException();

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            _list.Clear();
            _size = 0;
            _index = 0;

        }
        _disposed = true;
    }

    public bool MoveNext()
    {
        if (_size == 0) return false;
        if (_index < _size - 1)
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
