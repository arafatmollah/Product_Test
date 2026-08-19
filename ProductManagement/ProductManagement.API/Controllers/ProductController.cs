using Aggregator.Services;
using DTO.Product;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductAggregator _productAggregator;

    public ProductController(ProductAggregator productAggregator)
    {
        _productAggregator = productAggregator;
    }

    [HttpPost]
    public async Task<ActionResult<ProductResponse>> Create(
        CreateProductRequest request)
    {
        var result = await _productAggregator.CreateAsync(request);

        return Ok(result);
    }
}