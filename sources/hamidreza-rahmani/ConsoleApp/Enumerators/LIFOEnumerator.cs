using System.Collections;
using ConsoleApp.Models;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private int _currentIndex;
    private readonly List<Product> _products;

    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        _currentIndex = products.Count;
    }

    public Product Current => _products[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        if (_currentIndex > 0)
        {
            _currentIndex--;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _currentIndex = _products.Count;
    }
}