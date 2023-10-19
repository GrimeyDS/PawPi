using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Specialty;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models.Specialty;

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
            var specialtyResponseDto = specialties.Items.MapSpecialtiesDto();

            return Ok(specialtyResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var specialty = await _specialtyService.GetByIdAsync(id);

            if (!specialty.IsSuccess)
                return BadRequest(specialty.Errors);

            var specialtyResponseDto = specialty.Item.MapSpecialtyDto();

            return Ok(specialtyResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SpecialtyRequestDto specialtyRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values);

            var specialtyModel = new SpecialtyAddModel
            {
                Name = specialtyRequestDto.Name,
                Description = specialtyRequestDto.Description,
                VeterinarianIds = specialtyRequestDto.VeterinarianIds,
            };

            var result = await _specialtyService.AddAsync(specialtyModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(SpecialtyRequestDto specialtyRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values);

            var specialtyModel = new SpecialtyUpdateModel
            {
                Id = specialtyRequestDto.Id,
                Name = specialtyRequestDto.Name,
                Description = specialtyRequestDto.Description,
                VeterinarianIds = specialtyRequestDto.VeterinarianIds
            };

            var result = await _specialtyService.UpdateAsync(specialtyModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok();
        }
    }
}
