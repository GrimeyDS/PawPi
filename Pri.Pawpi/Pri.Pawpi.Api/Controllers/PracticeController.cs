using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Practice.Request;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeController : BaseController<Practice>
    {
        private readonly IPracticeService _practiceService;

        public PracticeController(IPracticeService practiceService) : base(practiceService)
        {
            _practiceService = practiceService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var practices = await _practiceService.GetAllAsync();
            var practiceResponseDto = practices.Items.MapDto();

            return Ok(practiceResponseDto);
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            var practice = await _practiceService.GetByIdAsync(id);

            if (!practice.IsSuccess)
                return BadRequest(practice.Errors);

            var practiceResponseDto = practice.Item.MapDto();

            return Ok(practiceResponseDto);
        }

        [HttpGet("searchName/{name}")]
        [AllowAnonymous]
        public async Task<IActionResult> SearchByName(string name)
        {
            var practices = await _practiceService.SearchByNameAsync(name);

            if (!practices.IsSuccess)
                return NotFound(practices.Errors);

            var practiceResponseDto = practices.Items.MapDto(name);

            return Ok(practiceResponseDto);
        }

        [HttpGet("searchAddress/{address}")]
        [AllowAnonymous]
        public async Task<IActionResult> SearchByAddress(string address)
        {
            var practices = await _practiceService.SearchByAddressAsync(address);

            if (!practices.IsSuccess)
                return NotFound(practices.Errors);

            var practiceResponseDto = practices.Items.MapDto(address);

            return Ok(practiceResponseDto);
        }

        [HttpGet("{id}/Veterinarians")]
        [AllowAnonymous]
        public async Task<IActionResult> GetVeterinariansByPractice(int id)
        {
            var vets = await _practiceService.GetVeterinariansFromPracticeAsync(id);
            var practice = await _practiceService.GetByIdAsync(id);

            if (!vets.IsSuccess)
                return BadRequest(vets.Errors);

            var name = $"{practice.Item.Name}";

            var practiceResponseDto = vets.Items.MapDto(name);

            return Ok(practiceResponseDto);
        }

        [HttpGet("{id}/Customers")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> GetCustomersByPractice(int id)
        {
            var customers = await _practiceService.GetCustomersByPracticeAsync(id);
            var practice = await _practiceService.GetByIdAsync(id);

            if (!customers.IsSuccess)
                return BadRequest(customers.Errors);

            var name = $"{practice.Item.Name}";

            var practiceResponseDto = customers.Items.MapDto(name);

            return Ok(practiceResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Create([FromForm] PracticeCreateDto practiceCreateDto)
        {
            var practiceModel = practiceCreateDto.MapModel();

            var result = await _practiceService.AddAsync(practiceModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Practice")]
        public async Task<IActionResult> Update([FromForm] PracticeUpdateDto PracticeUpdateDto)
        {
            var practiceModel = PracticeUpdateDto.MapModel();

            var result = await _practiceService.UpdateAsync(practiceModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
