using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : Controller
    {
        protected readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pets = await _petService.GetAllAsync();

            var petResponseDto = pets.Items.MapPetsDto();

            return Ok(petResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pet = await _petService.GetByIdAsync(id);

            if (!pet.IsSuccess)
                return BadRequest(pet.Errors);

            var customerResponseDto = pet.Item.MapPetDto();

            return Ok(customerResponseDto);
        }
    }
}
