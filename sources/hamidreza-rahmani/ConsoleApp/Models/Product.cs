namespace ConsoleApp.Models;

public class Product
{
    public Product(int code, string name)
    {
        Code = code;
        Name = name;
    }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public override string ToString()
    {
        return $"Product {Code}, Name:{Name}";
    }
}