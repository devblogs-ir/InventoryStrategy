using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private List<Product> _products = new();
    private int _index = -1;
    public FIFOEnumerator(List<Product> products)
    {
        _products = products;
    }

    public Product Current => _products[_index];

    object IEnumerator.Current => _products[_index];

    public void Dispose()
    {
       _products.Clear();
    }

    public bool MoveNext()
    {
        int index = _index + 1;
        int count = _products.Count;

        if (index < count)
        {
            _index = index;
            return true;
        }

        _index = count;
        return false;
    }

    public void Reset()
    {
        _index=-1;
    }
}
