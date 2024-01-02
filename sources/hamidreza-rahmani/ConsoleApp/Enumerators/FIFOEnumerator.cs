using System.Collections;
using ConsoleApp.Models;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private readonly List<Product> _products = new();
    private int _currentIndex;

    public FIFOEnumerator(List<Product> products)
    {
        _currentIndex = -1;
        _products = products;
    }

    public Product Current => _products[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        if (_currentIndex >= _products.Count - 1)
            return false;

        _currentIndex++;
        return true;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}