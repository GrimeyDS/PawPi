using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
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
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var veterinarians = await _veterinarianService.GetAllAsync();
            var veterinarianResponseDto = veterinarians.Items.MapDto();

            return Ok(veterinarianResponseDto);
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            var veterinarian = await _veterinarianService.GetByIdAsync(id);

            if (!veterinarian.IsSuccess)
                return BadRequest(veterinarian.Errors);

            var veterinarianResponseDto = veterinarian.Item.MapDto();

            return Ok(veterinarianResponseDto);
        }

        [HttpGet("searchName/{name}")]
        [AllowAnonymous]
        public async Task<IActionResult> SearchByName(string name)
        {
            var veterinarians = await _veterinarianService.SearchByNameAsync(name);

            if (!veterinarians.IsSuccess)
                return NotFound(veterinarians.Errors);

            var veterinarianResponseDto = veterinarians.Items.MapDto(name);

            return Ok(veterinarianResponseDto);
        }

        [HttpGet("{id}/Specialties")]
        [AllowAnonymous]
        public async Task<IActionResult> GetSpecialtiesFromVeterinarians(int id)
        {
            var specialties = await _veterinarianService.GetSpecialtiesFromVeterinariansAsync(id);
            var vet = await _veterinarianService.GetByIdAsync(id);

            if (!specialties.IsSuccess)
                return BadRequest(specialties.Errors);

            var name = $"{vet.Item.FirstName} {vet.Item.LastName}";

            var veterinarianResponseDto = specialties.Items.MapDto(name);

            return Ok(veterinarianResponseDto);
        }

        [HttpGet("{id}/Consultations")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> GetConsultationsFromVeterinarians(int id)
        {
            var consultations = await _veterinarianService.GetConsultationsFromVeterinariansAsync(id);
            var vet = await _veterinarianService.GetByIdAsync(id);

            if (!consultations.IsSuccess)
                return BadRequest(consultations.Errors);

            var name = $"{vet.Item.FirstName} {vet.Item.LastName}";

            var veterinarianResponseDto = consultations.Items.MapDto(name);

            return Ok(veterinarianResponseDto);
        }

        [HttpGet("{id}/Practices")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPracticesFromVeterinarians(int id)
        {
            var practices = await _veterinarianService.GetPracticesFromVeterinariansAsync(id);
            var vet = await _veterinarianService.GetByIdAsync(id);

            if (!practices.IsSuccess)
                return BadRequest(practices.Errors);

            var name = $"{vet.Item.FirstName} {vet.Item.LastName}";

            var veterinarianResponseDto = practices.Items.MapDto(name);

            return Ok(veterinarianResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Practice")]
        public async Task<IActionResult> Create([FromForm] VeterinarianCreateDto veterinarianCreateDto)
        {
            var veterinarianModel = veterinarianCreateDto.MapModel();

            var result = await _veterinarianService.AddAsync(veterinarianModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Update([FromForm] VeterinarianUpdateDto veterinarianUpdateDto)
        {
            var veterinarianModel = veterinarianUpdateDto.MapModel();

            var result = await _veterinarianService.UpdateAsync(veterinarianModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
