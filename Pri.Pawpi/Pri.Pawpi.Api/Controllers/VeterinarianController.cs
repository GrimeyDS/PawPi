using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarianController : Controller
    {
        protected readonly IVeterinarianService _veterinarianService;

        public VeterinarianController(IVeterinarianService veterinarianService)
        {
            _veterinarianService = veterinarianService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var veterinarians = await _veterinarianService.GetAllAsync();

            var vetResponseDto = veterinarians.Items.MapVeterinariansDto();

            return Ok(vetResponseDto);
        }
    }
}
