using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console.Enumerators
{
    public class LIFOEnumerator : IEnumerator<IProduct>
    {
        private List<IProduct> products;
        private int currentIndex;

        public LIFOEnumerator(List<IProduct> products)
        {
            this.products = products;
            currentIndex = products.Count;
        }

        public IProduct Current => products[currentIndex];
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            products.Clear();
        }
        public bool MoveNext()
        {
            currentIndex--;
            return currentIndex >= 0;
        }
        public void Reset()
        {
            currentIndex = products.Count;
        }
    }
}
