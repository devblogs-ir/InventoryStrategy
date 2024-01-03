using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Models;

public class Product
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public Product(int code, string name)
    {
        Code = code;
        Name = name;
    }

    public override string ToString() => $"Product {Code}, Name:{Name}";
}



