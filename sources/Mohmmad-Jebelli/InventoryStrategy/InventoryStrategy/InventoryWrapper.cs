using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy;

public class InventoryWrapper : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach;
    public List<Product> Products;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        Products = new List<Product>();
    }

    public void Add(Product product) => Products.Add(product);


    public IEnumerator<Product> GetEnumerator()
    {
        BaseEnuemrator<Product> enumerator = null;
        switch (_managementApproach)
        {
            case InventoryManagementApproach.LastInFirstOut:
                enumerator = new LIFOEnumerator<Product>(Products);
                break;

            case InventoryManagementApproach.FirstInFirstOut:
                enumerator = new FIFOEnumerator<Product>(Products);
                break;

            default:
                throw new NotImplementedException();
        }

        while (enumerator.MoveNext())
        {
            yield return enumerator.Current;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


}

