using InventoryStrategy.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
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

    public void Add(Product product)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Product> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

