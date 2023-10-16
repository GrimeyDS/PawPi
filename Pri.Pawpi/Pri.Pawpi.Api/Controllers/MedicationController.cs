using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Medication;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models.Medication;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : Controller
    {
        protected readonly IMedicationService _medicationService;
        protected readonly IPetService _petService;

        public MedicationController(IMedicationService medicationService, IPetService petService)
        {
            _medicationService = medicationService;
            _petService = petService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var medicine = await _medicationService.GetAllAsync();
            var medicineResponseDto = medicine.Items.Select(m => new MedicationResponseDto
            {
                Id = m.Id,
                Name = m.Name,
                Notes = m.Notes,
                SideEffects = m.SideEffects
            });

            return Ok(medicineResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var medicine = await _medicationService.GetByIdAsync(id);
            var medicineResponseDto = new MedicationResponseDto
            {
                Id = medicine.Item.Id,
                Name = medicine.Item.Name,
                Notes = medicine.Item.Notes,
                SideEffects = medicine.Item.SideEffects
            };

            return Ok(medicineResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MedicationRequestDto medicationRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values);

            var medicationModel = new MedicationAddModel
            {
                Name = medicationRequestDto.Name,
                Notes = medicationRequestDto.Notes,
                SideEffects = medicationRequestDto.SideEffects,
                PetIds = medicationRequestDto.PetIds,
                Dosage = medicationRequestDto.Dosage,
                Frequency = medicationRequestDto.Frequency
            };

            var result = await _medicationService.AddAsync(medicationModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(MedicationRequestDto medicationRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values);

            var medicationModel = new MedicationUpdateModel
            {
                Id = medicationRequestDto.Id,
                Name = medicationRequestDto.Name,
                Notes = medicationRequestDto.Notes,
                SideEffects = medicationRequestDto.SideEffects,
                PetIds = medicationRequestDto.PetIds,
                Dosage = medicationRequestDto.Dosage,
                Frequency = medicationRequestDto.Frequency
            };

            var result = await _medicationService.UpdateAsync(medicationModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _medicationService.DeleteAsync(id);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok();
        }
    }
}
