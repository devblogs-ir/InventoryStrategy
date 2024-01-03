using InventoryStrategy.ConsoleApp.Models;
using System.Collections;

namespace InventoryStrategy.ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private int currentIndex = -1;
    private List<Product> _products;

    public FIFOEnumerator(List<Product> products)
    {
        _products = products ?? throw new ArgumentNullException(nameof(products));
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
        if (++currentIndex < _products.Count)
        {
            return true;
        }

        return false;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
}