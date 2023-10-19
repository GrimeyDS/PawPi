using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Specialty.Request;
using Pri.Pawpi.Api.Dtos.Specialty.Response;
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
        public async Task<IActionResult> Get()
        {
            var specialties = await _specialtyService.GetAllAsync();
            var specialtyResponseDto = specialties.Items.MapDto();

            return Ok(specialtyResponseDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var specialty = await _specialtyService.GetByIdAsync(id);

            if (!specialty.IsSuccess)
                return BadRequest(specialty.Errors);

            var specialtyResponseDto = specialty.Item.MapDto();

            return Ok(specialtyResponseDto);
        }

        [HttpGet("search/{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var specialties = await _specialtyService.SearchByNameAsync(name);

            if (!specialties.IsSuccess)
                return NotFound(specialties.Errors);

            var specialtyResponseDto = new SpecialtySearchByNameDto { Specialties = specialties.Items.Select(s => s.MapDto()) };

            return Ok(specialtyResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SpecialtyCreateDto specialtyCreateDto)
        {
            var specialtyModel = specialtyCreateDto.MapModel();

            var result = await _specialtyService.AddAsync(specialtyModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
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
