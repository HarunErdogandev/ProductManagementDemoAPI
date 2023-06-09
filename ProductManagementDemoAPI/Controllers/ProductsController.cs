using Business.Abstract;
using Entities.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagementDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var Result = _productService.GetAll();
            if (Result.Success)
            {
                return Ok(Result.Data);
            }

            return BadRequest(Result.Message);

        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var Result = _productService.GetByCategory(categoryId);
            if (Result.Success)
            {
                return Ok(Result.Data);
            }

            return BadRequest(Result.Message);

        }
        [HttpGet("getbyproduct")]
        public IActionResult Get(int productId)
        {
            var Result = _productService.GetById(productId);
            if (Result.Success)
            {
                return Ok(Result.Data);
            }

            return BadRequest(Result.Message);

        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var Result = _productService.Add(product);

            if (Result.Success)
            {
                return Ok(Result.Message);
            }

            return BadRequest(Result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var Result = _productService.Delete(product);

            if (Result.Success)
            {
                return Ok(Result.Message);
            }

            return BadRequest(Result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var Result = _productService.Update(product);

            if (Result.Success)
            {
                return Ok(Result.Message);
            }

            return BadRequest(Result.Message);
        }

    }
}
