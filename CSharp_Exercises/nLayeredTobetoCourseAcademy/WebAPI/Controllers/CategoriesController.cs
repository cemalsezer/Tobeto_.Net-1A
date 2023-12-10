using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest category)
        {
            await _categoryService.Add(category); 
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync(); 
            return Ok(result);
        }

        //[HttpPut("update")]
        //[HttpPatch("update")]
        //public async Task<IActionResult> Update([FromBody] Category category)
        //{
        //    await _categoryService.Update(category);
        //    return Ok();
        //}

        //[HttpPost("delete")]
        //public async Task<IActionResult> Delete([FromBody] Category category)
        //{
        //    await _categoryService.Delete(category);
        //    return Ok();
        //}
    }
}
