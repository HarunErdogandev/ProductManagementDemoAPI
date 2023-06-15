using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagementDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public ICategoryService _categoryService;
         
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            
        }

        [HttpGet("getcategoryıd")]
        
        public IActionResult GetByCategory(int categoryid)
        {
            var Result=_categoryService.GetCategoryById(categoryid);
            if (Result.Success)
            {
                return Ok(Result.Data);
            }
            return BadRequest(Result.Message);
            
        }


        [HttpGet("getall")]
        [Authorize()]
        public IActionResult GetAll()
        {
            var Result=_categoryService.GetList();
            if (Result.Success)
            {
                return Ok(Result.Data);
            }
            return BadRequest(Result.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var Result = _categoryService.Add(category);

            if (Result.Success)
            {
                return Ok(Result.Message);
            }

            return BadRequest(Result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            var Result = _categoryService.Delete(category);

            if (Result.Success)
            {
                return Ok(Result.Message);
            }

            return BadRequest(Result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var Result = _categoryService.Update(category);

            if (Result.Success)
            {
                return Ok(Result.Message);
            }

            return BadRequest(Result.Message);
        }
    }
}
