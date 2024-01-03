using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private readonly List<Product> _products;
    private int _current;

    public FIFOEnumerator(List<Product> products)
    {
        _current = -1;
        _products = products;
    }

    public Product Current => _products[_current];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        if (_current < _products.Count - 1)
        {
            _current++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _current = -1;
    }
}
