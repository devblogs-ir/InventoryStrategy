using InventoryStrategy.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private List<Product> _products;
    private int _index ;
    public LIFOEnumerator(List<Product> products)
    {
        _products=products;
        _index = _products.Count ;
    }

    public Product Current => _products![_index] ;

    object IEnumerator.Current => _products![_index];

    public void Dispose()
    {
        _products = null!;
    }

    public bool MoveNext()
    {
        int index = _index - 1;
        int length = _products!.Count;

        if (index > -1)
        {
            _index = index;
            return true;
        }

        _index = -1;
        return false;
    }

    public void Reset()
    {
        _index = _products.Count-1;
    }
}
