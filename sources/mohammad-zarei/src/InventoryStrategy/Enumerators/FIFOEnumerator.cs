using System.Collections;

namespace InventoryStrategy.Enumerators;

public class FIFOEnumerator<T> : IEnumerator<T>
{
    private readonly List<T> _goods;
    private int _currentIndex = -1;

    public FIFOEnumerator(List<T> goods)
    {
        _goods = new List<T>(goods);
    }

    public T Current => _goods[_currentIndex];

    object IEnumerator.Current => Current;


    public void Dispose()
    {
        _goods.Clear();
    }

    public bool MoveNext()
    {
        return ++_currentIndex < _goods.Count;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}
