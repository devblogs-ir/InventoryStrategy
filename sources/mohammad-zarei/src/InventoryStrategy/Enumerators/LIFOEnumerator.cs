using System.Collections;

namespace InventoryStrategy.Enumerators;

public class LIFOEnumerator<T> : IEnumerator<T>
{
    private readonly List<T> _goods;
    private int _currentIndex;

    public LIFOEnumerator(List<T> goods)
    {
        _goods = new List<T>(goods);
        _currentIndex = _goods.Count;
    }

    public T Current => _goods[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _goods.Clear();
    }

    public bool MoveNext()
    {
        return --_currentIndex >= 0;
    }

    public void Reset()
    {
        _currentIndex = _goods.Count;
    }
}
