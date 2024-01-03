using InventoryStrategy.Console.Enumerators;
using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console
{
    public class InventoryWrapper : IEnumerable<IProduct>
    {
        public InventoryManagementApproach _managementApproach;
        public List<IProduct> Products;
        public IEnumerator<IProduct> enumerator;

        public InventoryWrapper(InventoryManagementApproach managementApproach)
        {
            _managementApproach = managementApproach;
            Products = new List<IProduct>();
        }

        public void Add(IProduct product)
        {
            Products.Add(product);
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            if (_managementApproach == InventoryManagementApproach.FirstInFirstOut)
            {
                enumerator = new FIFOEnumerator(Products);
            }
            else if (_managementApproach == InventoryManagementApproach.LastInFirstOut)
            {
                enumerator = new LIFOEnumerator(Products);
            }
            else
            {
                throw new InvalidOperationException("Invalid inventory management approach.");
            }

            return enumerator;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}
