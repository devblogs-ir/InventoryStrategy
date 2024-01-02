using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private readonly List<Product> _products;

    private int _currentPosition;
    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        _currentPosition = _products.Count;
    }

    public Product Current
    {
        get
        {
            return _products[_currentPosition];
        }
    }
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        if (_currentPosition > 0)
        {
            _currentPosition--;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {
        _currentPosition = _products.Count;
    }
}
