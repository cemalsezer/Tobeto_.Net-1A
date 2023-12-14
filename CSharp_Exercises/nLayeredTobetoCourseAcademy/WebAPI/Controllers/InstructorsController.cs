using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        IInstructorService _instructorService;
        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest instructor)
        {
            var result = await _instructorService.Add(instructor);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync();
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateInsturctorRequest instructor)
        {
            var result = await _instructorService.Update(instructor);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteInstructorRequest instructor)
        {
            var result = await _instructorService.Delete(instructor);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _instructorService.GetAsync(c => c.Id == id);
            return Ok(result);
        }
    }
}
