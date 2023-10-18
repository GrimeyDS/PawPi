using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Specialty;
using Pri.Pawpi.Api.Dtos.Veterinarian;
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

            var vetResponseDto = veterinarians.Items.Select(v => new VeterinarianResponseDto
            {
                Id = v.Id,
                FirstName = v.FirstName,
                LastName = v.LastName,
                Birth = v.Birth,
                Address = v.Address,
                City = v.City,
                Email = v.Email,
                Phone = v.Phone,
                Postal = v.Postal,
            });

            return Ok(vetResponseDto);
        }


    }
}
