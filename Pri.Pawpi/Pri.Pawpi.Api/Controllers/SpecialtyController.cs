using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Specialty.Request;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyController : BaseController<Specialty>
    {

        private readonly ISpecialtyService _specialtyService;

        public SpecialtyController(ISpecialtyService specialtyService) : base(specialtyService)
        {
            _specialtyService = specialtyService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var specialties = await _specialtyService.GetAllAsync();
            var specialtyResponseDto = specialties.Items.MapDto();

            return Ok(specialtyResponseDto);
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            var specialty = await _specialtyService.GetByIdAsync(id);

            if (!specialty.IsSuccess)
                return BadRequest(specialty.Errors);

            var specialtyResponseDto = specialty.Item.MapDto();

            return Ok(specialtyResponseDto);
        }

        [HttpGet("searchName/{name}")]
        [AllowAnonymous]
        public async Task<IActionResult> SearchByName(string name)
        {
            var specialties = await _specialtyService.SearchByNameAsync(name);

            if (!specialties.IsSuccess)
                return NotFound(specialties.Errors);

            var specialtyResponseDto = specialties.Items.MapDto(name);

            return Ok(specialtyResponseDto);
        }

        [HttpGet("{id}/Veterinarians")]
        [AllowAnonymous]
        public async Task<IActionResult> GetVetsFromSpecialty(int id)
        {
            var vets = await _specialtyService.GetVetsFromSpecialtyAsync(id);
            var specialty = await _specialtyService.GetByIdAsync(id);

            if (!vets.IsSuccess)
                return BadRequest(vets.Errors);

            var name = specialty.Item.Name;

            var specialtyResponseDto = vets.Items.MapDto(name);

            return Ok(specialtyResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Veterinarian")]
        public async Task<IActionResult> Create(SpecialtyCreateDto specialtyCreateDto)
        {
            var specialtyModel = specialtyCreateDto.MapModel();

            var result = await _specialtyService.AddAsync(specialtyModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Veterinarian")]
        public async Task<IActionResult> Update(SpecialtyUpdateDto specialtyUpdateDto)
        {
            var specialtyUpdateModel = specialtyUpdateDto.MapModel();

            var result = await _specialtyService.UpdateAsync(specialtyUpdateModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
