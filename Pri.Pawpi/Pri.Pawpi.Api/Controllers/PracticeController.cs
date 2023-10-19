using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeController : BaseController<Practice>
    {
        private readonly IPracticeService _practiceService;

        public PracticeController(IPracticeService practiceService) : base(practiceService)
        {
            _practiceService = practiceService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var practices = await _practiceService.GetAllAsync();

            var practicesResponseDto = practices.Items.MapPracticesDto();

            return Ok(practicesResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var practice = await _practiceService.GetByIdAsync(id);

            if (!practice.IsSuccess)
                return BadRequest(practice.Errors);

            var practiceResponseDto = practice.Item.MapPracticeDto();

            return Ok(practiceResponseDto);
        }
    }
}
