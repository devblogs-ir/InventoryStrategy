using System.Collections;

namespace InventoryStrategy.Console.Enumerators;

public class FifoEnumerator<T> : IEnumerator<T>
{
    private List<T> _products;
    private int currentIndex;

    public FifoEnumerator(List<T> products)
    {
        _products = products;
        currentIndex = -1;
    }

    public T Current => _products[currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() => _products.Clear();

    public bool MoveNext()
    {
        currentIndex++;
        return currentIndex < _products.Count;
    }

    public void Reset() => currentIndex = -1;
}
