namespace Models;

public class Product(int ProductCode_, string ProductName_)
{
    public int ProductCode { get; init; } = ProductCode_;
    public  string ProductName { get; init; } = ProductName_;

    public override string ToString() => $"Product Code {ProductCode} , Product Name {ProductName}"; 
}