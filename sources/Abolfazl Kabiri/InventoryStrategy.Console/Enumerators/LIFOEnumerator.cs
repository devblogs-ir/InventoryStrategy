using System.Collections;

namespace InventoryStrategy.Console.Enumerators;

public class LifoEnumerator<T> : IEnumerator<T>
{
    private List<T> _items;
    private int _currentIndex;

    public LifoEnumerator(List<T> products)
    {
        _items = products;
        currentIndex = products.Count;
    }

    public T Current => _items[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() => _items.Clear();

    public bool MoveNext()
    {
        currentIndex--;
        return currentIndex >= 0;
    }

    public void Reset() => _currentIndex = _items.Count;

}
