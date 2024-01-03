using InventoryStrategy.ConsoleApp.Models;
using System.Collections;
using InventoryStrategy.ConsoleApp.Enumerators;

namespace InventoryStrategy.ConsoleApp;

public class InventoryWrapper : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach;
    public List<Product> _products = new List<Product>();

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
    }

    public void Add(Product product) => _products.Add(product);


    public IEnumerator<Product> GetEnumerator()
    {
        switch (_managementApproach)
        {
            case InventoryManagementApproach.FirstInFirstOut:
                return new FIFOEnumerator(_products);
            case InventoryManagementApproach.LastInFirstOut:
                return new LIFOEnumerator(_products);
            default:
                throw new InvalidOperationException("Unsupported inventory management approach.");
        }
    }


    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}
