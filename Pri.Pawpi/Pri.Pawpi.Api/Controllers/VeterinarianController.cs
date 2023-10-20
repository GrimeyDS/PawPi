using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarianController : BaseController<Veterinarian>
    {

        private readonly IVeterinarianService _veterinarianService;

        public VeterinarianController(IVeterinarianService veterinarianService) : base(veterinarianService)
        {
            _veterinarianService = veterinarianService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var veterinarians = await _veterinarianService.GetAllAsync();

            //var vetResponseDto = veterinarians.Items.MapVeterinariansDto();

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var veterinarians = await _veterinarianService.GetByIdAsync(id);

            if (!veterinarians.IsSuccess)
                return BadRequest(veterinarians.Errors);

            //var veterinarianResponseDto = veterinarians.Item.MapVeterinarianDto();

            return Ok();
        }
    }
}
