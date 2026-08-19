using Aggregator.Entities;

namespace Aggregator.Services;

public class ProductAggregator
{
    public Product Create(
        string name,
        string description,
        decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name is required.");

        if (price <= 0)
            throw new ArgumentException(
                "Product price must be greater than zero.");

        return new Product
        {
            Name = name,
            Description = description,
            Price = price
        };
    }
}