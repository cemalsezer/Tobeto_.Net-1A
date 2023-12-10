using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest course)
        {
            await _courseService.Add(course);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }

        //[HttpPut("update")]
        //[HttpPatch("update")]
        //public async Task<IActionResult> Update([FromBody] Course course)
        //{
        //    await _courseService.Update(course);
        //    return Ok();
        //}

        //[HttpPost("delete")]
        //public async Task<IActionResult> Delete([FromBody] Course course)
        //{
        //    await _courseService.Delete(course);
        //    return Ok();
        //}
    }
}
