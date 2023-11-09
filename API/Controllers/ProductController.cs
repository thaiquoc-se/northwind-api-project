using API.DTOs;
using API.ViewModels;
using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IProductService productService, IMapper mapper, ILogger<ProductController> logger)
        {
            _productService = productService;
            _mapper = mapper;
            _logger = logger;
        }

        [Route("products")]
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllProducts().ToListAsync();
                var response = _mapper.Map<IEnumerable<ProductDTO>>(products);
                _logger.LogInformation("ProductController: Get method called");
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [Route("products/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetProductByID(int id)
        {
            try
            {
                var product = await _productService.GetAllProducts().Where(p => p.ProductId == id).FirstOrDefaultAsync();
                var response = _mapper.Map<ProductDTO>(product);
                return Ok(response);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("create-new-product")]
        [HttpPost]
         public async Task<IActionResult> CreateNewProduct(ProductViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  var newProduct = _mapper.Map<Product>(model);
                  await _productService.Add(newProduct);
                  return Ok();
                }
                return BadRequest();
            }catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
