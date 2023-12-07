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

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Instructor instructor)
        {
            await _instructorService.Add(instructor); return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync(); return Ok(result);
        }
    }
}
