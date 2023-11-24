using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Medication.Request;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : BaseController<Medication>
    {
        private readonly IMedicationService _medicationService;

        public MedicationController(IMedicationService medicationService) : base(medicationService)
        {
            _medicationService = medicationService;
        }

        [HttpGet]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get()
        {
            var medicine = await _medicationService.GetAllAsync();
            var medicationResponseDto = medicine.Items.MapDto();

            return Ok(medicationResponseDto);
        }

        [HttpGet("{id:int}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get(int id)
        {
            var medication = await _medicationService.GetByIdAsync(id);

            if (!medication.IsSuccess)
                return BadRequest(medication.Errors);

            var medicationResponseDto = medication.Item.MapDto();

            return Ok(medicationResponseDto);
        }

        [HttpGet("{id}/Pets")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> GetPetsFromMedication(int id)
        {
            var pets = await _medicationService.GetPetsByMedicationIdAsync(id);
            var medication = await _medicationService.GetByIdAsync(id);

            if (!pets.IsSuccess)
                return BadRequest(pets.Errors);

            var name = medication.Item.Name;

            var medicationResponseDto = pets.Items.MapDto(name);

            return Ok(medicationResponseDto);
        }

        [HttpGet("searchName/{name}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var medicine = await _medicationService.SearchByNameAsync(name);

            if (!medicine.IsSuccess)
                return NotFound(medicine.Errors);

            var medicationResponseDto = medicine.Items.MapDto(name);

            return Ok(medicationResponseDto);
        }

        [HttpGet("searchSideEffect/{sideEffect}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchBySideEffect(string sideEffect)
        {
            var medicine = await _medicationService.SearchBySideEffectAsync(sideEffect);

            if (!medicine.IsSuccess)
                return NotFound(medicine.Errors);

            var medicationResponseDto = medicine.Items.MapDto(sideEffect);

            return Ok(medicationResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Veterinarian")]
        public async Task<IActionResult> Create(MedicationCreateDto medicationCreateDto)
        {
            var medicationModel = medicationCreateDto.MapModel();

            var result = await _medicationService.AddAsync(medicationModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Veterinarian")]
        public async Task<IActionResult> Update(MedicationUpdateDto medicationUpdateDto)
        {
            var medicationUpdateModel = medicationUpdateDto.MapModel();

            var result = await _medicationService.UpdateAsync(medicationUpdateModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
