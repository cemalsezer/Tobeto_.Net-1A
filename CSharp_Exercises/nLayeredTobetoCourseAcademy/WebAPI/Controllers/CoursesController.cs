using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest course)
        {
            var result = await _courseService.Add(course);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseRequest course)
        {
            var result = await _courseService.Update(course);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseRequest course)
        {
            var result = await _courseService.Delete(course);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _courseService.GetAsync(c => c.Id == id);
            return Ok(result);
        }
    }
}
