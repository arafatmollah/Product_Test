using Aggregator.Services;
using DTO.Product;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductAggregator _productAggregator;
    private readonly Createproducthan _createProduct;

    public ProductController(ProductAggregator productAggregator)
    {
        _productAggregator = productAggregator;
    }

    [HttpPost]
    public ActionResult<ProductResponse> Create(
    CreateProductRequest request)
    {
        var result = _productAggregator.Create(request);

        return Ok(result);
    }
}