namespace Handler.Commands.CreateProduct;

public class CreateProductCommand
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}