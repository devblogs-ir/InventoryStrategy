using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console.Enumerators
{
    public class FIFOEnumerator : IEnumerator<IProduct>
    {
        private List<IProduct> products;
        private int currentIndex;

        public FIFOEnumerator(List<IProduct> products)
        {
            this.products = products;
            currentIndex = -1;
        }
        public IProduct Current => products[currentIndex];
        object IEnumerator.Current => Current;

        public void Dispose()
        {
            products.Clear();
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < products.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
