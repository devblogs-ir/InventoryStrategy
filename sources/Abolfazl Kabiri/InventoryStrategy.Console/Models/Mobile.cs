namespace InventoryStrategy.Console.Models;
internal class Mobile(int code, string name)
{
    public int Code { get; set; } = code;
    public string Name { get; set; } = name;
    public override string ToString() => $"Product {Code}, Name:{Name}";
}
