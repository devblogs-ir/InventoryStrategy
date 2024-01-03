using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console.Enumerators
{
    public class LIFOEnumerator : IEnumerator<IProduct>
    {
        private List<IProduct> _products;
        private int currentIndex;

        public LIFOEnumerator(List<IProduct> products)
        {
            _products = products;
            currentIndex = products.Count;
        }
        public IProduct Current => _products[currentIndex];
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            _products.Clear();
        }
        public bool MoveNext()
        {
            currentIndex--;
            return currentIndex >= 0;
        }
        public void Reset()
        {
            currentIndex = _products.Count;
        }
    }
}
