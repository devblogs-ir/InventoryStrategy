namespace InventoryStorage.Models;
public class Product
{
    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; init; }
    public string Name { get; init; }
}
