namespace ConsoleApp.Models;

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

