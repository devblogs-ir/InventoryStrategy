using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    List<Product> _products;
    int _currentProductIndex = -1;

    public FIFOEnumerator(List<Product> products)
    {
        _products = products;
    }

    public Product Current => _products[_currentProductIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        while (_currentProductIndex++ < _products.Count)
        {
            return true;
        }    
        return false;
    }

    public void Reset()
    {
        _currentProductIndex = -1;
    }
}
