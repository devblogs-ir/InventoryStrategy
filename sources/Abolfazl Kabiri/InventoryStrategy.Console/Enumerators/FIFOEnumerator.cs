using System.Collections;

namespace InventoryStrategy.Console.Enumerators;

public class FifoEnumerator<T> : IEnumerator<T>
{
    private List<T> _items;
    private int _currentIndex;

    public FifoEnumerator(List<T> products)
    {
        _items = products;
        currentIndex = -1;
    }

    public T Current => _items[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() => _items.Clear();

    public bool MoveNext()
    {
        currentIndex++;
        return currentIndex < _items.Count;
    }

    public void Reset() => _currentIndex = -1;
}
