using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
using Microsoft.VisualBasic;
using System.Collections;

namespace InventoryStrategy
{
    public class InventoryWrapper : IEnumerable<Product>
    {
        public InventoryManagementApproach _managementApproach;
        public List<Product> Products;
        private IEnumerator<Product> _productsEnumerator;

        public InventoryWrapper(InventoryManagementApproach managementApproach)
        {
            _managementApproach = managementApproach;
            Products = new List<Product>();           
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            if (_managementApproach == InventoryManagementApproach.FirstInFirstOut)
            {
                _productsEnumerator = new FIFOEnumerator(Products);
            }
            else
            {
                _productsEnumerator = new LIFOEnumerator(Products);
            }

            while (_productsEnumerator.MoveNext())
            {
                yield return _productsEnumerator.Current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
