using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private int _currentIndex;
    private readonly List<Product> _products;
    public LIFOEnumerator(List<Product> products)
    {
        _currentIndex = products.Count;
        _products = products;
    }

    public Product Current => _products[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        _currentIndex--;
        return _currentIndex >= 0;
    }

    public void Reset()
    {
        _currentIndex = _products.Count;
    }
}
