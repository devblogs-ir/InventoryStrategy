using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private List<Product> _products;
    private int _index;
    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        _index = _products.Count;
    }
    public Product Current
    {
        get
        {
            return _products[_index];
        }
    }

    object IEnumerator.Current => Current;
    public void Dispose()
    {
        _products.Clear();
        _index = -1;
    }
    public bool MoveNext()
    {
        int index = _index - 1;
        if (_index > 0 )
        {
            _index = index;
            return true;
        }
        _index = 0;
        return false;
    }
    public void Reset()
    {
        _index = _products.Count;
    }
}
