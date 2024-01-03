using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console.Enumerators
{
    public class FIFOEnumerator : IEnumerator<IProduct>
    {
        private List<IProduct> _products;
        private int currentIndex;
        public FIFOEnumerator(List<IProduct> products)
        {
            _products = products;
            currentIndex = -1;
        }
        public IProduct Current => _products[currentIndex];
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            _products.Clear();
        }
        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < _products.Count;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
