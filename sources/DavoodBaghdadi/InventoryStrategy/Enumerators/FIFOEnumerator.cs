using ConsoleApp.Models;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private readonly List<Product> _products;
    private int _currentPosition;
    public FIFOEnumerator(List<Product> products)
    {
        _products = products;
        Reset();
    }

    public Product Current
    {
        get
        {
            return _products[_currentPosition-1];
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return _products[_currentPosition];
        }
    }



    public void Dispose()
    {
        _products.Clear();
    }

    public bool MoveNext()
    {
        if (_currentPosition < _products.Count)
        {
            _currentPosition++;
            return true;
        }
        else { return false; }
    }

    public void Reset()
    {
        _currentPosition = 0;
    }
}
