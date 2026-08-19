
using Aggregator.Services;
using DTO.Product;
using Repository;

namespace Handler.Commands.CreateProduct;

public class CreateProductHandler(
    ProductAggregator productAggregator,
    IProductRepository productRepository)
{
    private readonly ProductAggregator _productAggregator =
        productAggregator;

    private readonly IProductRepository _productRepository =
        productRepository;

    public async Task<ProductResponse> HandleAsync(
        CreateProductCommand command)
    {
        var product = _productAggregator.Create(
            command.Name,
            command.Description,
            command.Price);

        var createdProduct =
            await _productRepository.AddAsync(product);

        return new ProductResponse
        {
            Id = createdProduct.Id,
            Name = createdProduct.Name,
            Description = createdProduct.Description,
            Price = createdProduct.Price
        };
    }
}