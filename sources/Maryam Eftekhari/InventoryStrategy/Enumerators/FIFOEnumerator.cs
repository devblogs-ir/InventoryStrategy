using InventoryStrategy.Models;
using System.Collections;

namespace InventoryStrategy.Enumerators
{
    public class FIFOEnumerator : IEnumerator<Product>
    {
        private int _position;
        private readonly List<Product> _products;
        public FIFOEnumerator(List<Product> products)
        {
            _products = products;
            Reset();
        }

        public Product Current => _products[_position];
        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _products.Clear();
        }

        public bool MoveNext()
        {
            if (_position < _products.Count - 1)
            {
                ++_position;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
