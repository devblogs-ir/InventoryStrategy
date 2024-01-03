using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private readonly List<Product> _products;
    private int _current;
    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        _current = _products.Count;
    }

    public Product Current => _products[_current];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        if (_current > 0 && _current <= _products.Count)
        {
            _current--;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _current = _products.Count;
    }
}
