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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ConsultationController(IConsultationService consultationService, IHttpContextAccessor httpContextAccessor) : base(consultationService)
        {
            _consultationService = consultationService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get()
        {
            var consultations = await _consultationService.GetAllAsync();
            var consultationResponseDto = consultations.Items.MapDto(_httpContextAccessor);

            return Ok(consultationResponseDto);
        }

        [HttpGet("{id:int}")]
        [Authorize(Policy = "AllUsers")]
        public async Task<IActionResult> Get(int id)
        {
            var consultation = await _consultationService.GetByIdAsync(id);

            var userMedClaims = HttpContext.User.Claims;
            var userValidated = userMedClaims.CheckUserIdentity(consultation.Item);

            if (!userValidated)
                return Forbid();

            if (!consultation.IsSuccess)
                return BadRequest(consultation.Errors);

            var consultationResponseDto = consultation.Item.MapDto(_httpContextAccessor);

            return Ok(consultationResponseDto);
        }

        [HttpGet("searchTitle/{title}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByTitle(string title)
        {
            var consultations = await _consultationService.SearchByTitleAsync(title);

            if (!consultations.IsSuccess)
                return NotFound(consultations.Errors);

            var consultationResponseDto = consultations.Items.MapDto(title, _httpContextAccessor);

            return Ok(consultationResponseDto);
        }

        [HttpGet("searchDiagnose/{diagnose}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByDiagnose(string diagnose)
        {
            var consultations = await _consultationService.SearchByDiagnoseAsync(diagnose);

            if (!consultations.IsSuccess)
                return NotFound(consultations.Errors);

            var consultationResponseDto = consultations.Items.MapDto(diagnose, _httpContextAccessor);

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
