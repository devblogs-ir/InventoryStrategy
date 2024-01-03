using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    List<Product> _products;
    int _currentProductIndex;

    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        _currentProductIndex = _products.Count;
    }

    public Product Current => _products[_currentProductIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        while(_currentProductIndex-- > -1)
        {
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _currentProductIndex = _products.Count;
    }
}
