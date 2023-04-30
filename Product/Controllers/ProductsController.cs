using LinkedInDemo.Api.Products.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LinkedInDemo.Api.Products.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private  IProductsProvider ProductsProvider {get;set;}
        public ProductsController(IProductsProvider productsProvider)
        {
            this.ProductsProvider = productsProvider;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.ProductsProvider.GetProductsAsync());
        }
    }
}
