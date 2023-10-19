using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Get()
        {
            var consultations = await _consultationService.GetAllAsync();

            var consultationResponseDto = consultations.Items.MapConsultationsDto();

            return Ok(consultationResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var consultation = await _consultationService.GetByIdAsync(id);

            if (!consultation.IsSuccess)
                return BadRequest(consultation.Errors);

            var consultationResponseDto = consultation.Item.MapConsultationDto();

            return Ok(consultationResponseDto);
        }
    }
}
