using ConsoleApp.Models;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private List<Product> _products = new();
    private int _index ;
    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        _index = products.Count();
    }

    public Product Current => _products[_index];

    object IEnumerator.Current => _products[_index];

    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        int index = _index - 1;
        int count = _products.Count;
        
        if ((index < count) && (index>-1))
        {
            _index = index;
            return true;
        }

        _index = count;
        return false;
    }

    public void Reset()
    {
        _index = -1;
    }
}
