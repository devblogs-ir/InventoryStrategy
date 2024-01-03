using InventoryStrategy.ConsoleApp.Models;
using System.Collections;

namespace InventoryStrategy.ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private readonly List<Product> _products;
    private int currentIndex;

    public LIFOEnumerator(List<Product> products)
    {
        _products = products ?? throw new ArgumentNullException(nameof(products));
        Reset();
    }

    public Product Current
    {
        get
        {
            if (currentIndex < 0 || currentIndex >= _products.Count)
            {
                throw new InvalidOperationException("not valid element.");
            }

            return _products[currentIndex];
        }
    }

    object IEnumerator.Current => Current;

    public void Dispose() => _products.Clear();

    public bool MoveNext()
    {
        return --currentIndex >= 0;
    }

    public void Reset()
    {
        currentIndex = _products.Count;
    }
}