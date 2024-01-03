namespace InventoryStrategy.Console.Models
{
    public class Laptop(int code, string name) : IProduct
    {
        public int Code { get; set; } = code;
        public string Name { get; set; } = name;
        public override string ToString() => $"Product {Code}, Name:{Name}";
    }
}
