using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Instructor instructor)
        {
            await _instructorService.Add(instructor);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync();
            return Ok(result);
        }

        [HttpPut("update")]
        [HttpPatch("update")]
        public async Task<IActionResult> Update([FromBody] Instructor instructor)
        {
            await _instructorService.Update(instructor);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] Instructor instructor)
        {
            await _instructorService.Delete(instructor);
            return Ok();
        }
    }
}
