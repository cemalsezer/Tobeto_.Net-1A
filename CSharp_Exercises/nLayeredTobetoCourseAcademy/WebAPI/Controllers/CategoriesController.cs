using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest category)
        {
            var result = await _categoryService.Add(category);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync();
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryRequest category)
        {
            var result = await _categoryService.Update(category);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCategoryRequest category)
        {
            var result = await _categoryService.Delete(category);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _categoryService.GetAsync(c => c.Id == id);
            return Ok(result);
        }
    }
}
