using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.IService;

namespace API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("GetAll")]
        [HttpGet]

        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts().ToListAsync();
            return Ok(products);
        }
    }
}
