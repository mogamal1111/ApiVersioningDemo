
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers.V2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = new[]
        {
            new
            {
                Id = 1,
                Name = "Laptop",
                Price = 25000,
                CategoryName = "Electronics"
            },
            new
            {
                Id = 2,
                Name = "Mouse",
                Price = 500,
                CategoryName = "Accessories"
            }
        };

        return Ok(products);
    }
}
