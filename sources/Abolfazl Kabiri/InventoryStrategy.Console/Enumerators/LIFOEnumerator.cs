using System.Collections;

namespace InventoryStrategy.Console.Enumerators;

public class LifoEnumerator<T> : IEnumerator<T>
{
    private List<T> _products;
    private int currentIndex;

    public LifoEnumerator(List<T> products)
    {
        _products = products;
        currentIndex = products.Count;
    }

    public T Current => _products[currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() => _products.Clear();

    public bool MoveNext()
    {
        currentIndex--;
        return currentIndex >= 0;
    }

    public void Reset() => currentIndex = _products.Count;

}
