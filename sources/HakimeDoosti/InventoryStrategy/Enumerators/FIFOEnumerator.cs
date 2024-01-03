using InventoryStrategy.Models;
using System.Collections;

namespace InventoryStrategy.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private List<Product> _products;
    private int _index =-1;
    public FIFOEnumerator(List<Product> products)
    {
        _products = products;
        _index = -1 ;
    }

    public Product Current =>  _products![_index];

    object IEnumerator.Current => _products![_index];

    public void Dispose()
    {
        _products = null!;
    }

    public bool MoveNext()
    {
        int index = _index + 1;
        int length = _products!.Count;

        if (index < length)
        {
            _index = index;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _index=-1;
    }
}
