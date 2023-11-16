using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Consultation.Request;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : BaseController<Consultation>
    {
        private readonly IConsultationService _consultationService;

        public ConsultationController(IConsultationService consultationService) : base(consultationService)
        {
            _consultationService = consultationService;
        }

        [HttpGet]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get()
        {
            var consultations = await _consultationService.GetAllAsync();
            var consultationResponseDto = consultations.Items.MapDto();

            return Ok(consultationResponseDto);
        }

        [HttpGet("{id:int}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get(int id)
        {
            var consultation = await _consultationService.GetByIdAsync(id);

            if (!consultation.IsSuccess)
                return BadRequest(consultation.Errors);

            var consultationResponseDto = consultation.Item.MapDto();

            return Ok(consultationResponseDto);
        }

        [HttpGet("searchTitle/{title}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByTitle(string title)
        {
            var consultations = await _consultationService.SearchByTitleAsync(title);

            if (!consultations.IsSuccess)
                return NotFound(consultations.Errors);

            var consultationResponseDto = consultations.Items.MapDto(title);

            return Ok(consultationResponseDto);
        }

        [HttpGet("searchDiagnose/{diagnose}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByDiagnose(string diagnose)
        {
            var consultations = await _consultationService.SearchByDiagnoseAsync(diagnose);

            if (!consultations.IsSuccess)
                return NotFound(consultations.Errors);

            var consultationResponseDto = consultations.Items.MapDto(diagnose);

            return Ok(consultationResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Veterinarian")]
        public async Task<IActionResult> Create([FromForm] ConsultationCreateDto consultationCreateDto)
        {
            var consultationModel = consultationCreateDto.MapModel();

            var result = await _consultationService.AddAsync(consultationModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Veterinarian")]
        public async Task<IActionResult> Update([FromForm] ConsultationUpdateDto consultationUpdateDto)
        {
            var consultationModel = consultationUpdateDto.MapModel();

            var result = await _consultationService.UpdateAsync(consultationModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
