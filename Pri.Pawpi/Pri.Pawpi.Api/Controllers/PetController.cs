using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Pet.Request;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;
using System.Security.Claims;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : BaseController<Pet>
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService) : base(petService)
        {
            _petService = petService;
        }

        [HttpGet]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get()
        {
            var pets = await _petService.GetAllAsync();
            var petResponseDto = pets.Items.MapDto();

            return Ok(petResponseDto);
        }

        [HttpGet("{id:int}")]
        [Authorize(Policy = "AllUsers")]
        public async Task<IActionResult> Get(int id)
        {
            var pet = await _petService.GetByIdAsync(id);

            var userPetClaims = HttpContext.User.Claims;
            var userValidated = userPetClaims.CheckUserIdentity(pet.Item);

            if (!userValidated)
                return Forbid();

            if (!pet.IsSuccess)
                return BadRequest(pet.Errors);

            var petResponseDto = pet.Item.MapDto();

            return Ok(petResponseDto);
        }

        [HttpGet("searchName/{name}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var pets = await _petService.SearchByNameAsync(name);

            if (!pets.IsSuccess)
                return NotFound(pets.Errors);

            var petResponseDto = pets.Items.MapDto(name);

            return Ok(petResponseDto);
        }

        [HttpGet("searchAnimalType/{animalType}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByAnimalType(string animalType)
        {
            var pets = await _petService.SearchByAnimalTypeAsync(animalType);

            if (!pets.IsSuccess)
                return NotFound(pets.Errors);

            var petResponseDto = pets.Items.MapDto(animalType);

            return Ok(petResponseDto);
        }

        [HttpGet("searchBreed/{breed}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByBreed(string breed)
        {
            var pets = await _petService.SearchByBreedAsync(breed);

            if (!pets.IsSuccess)
                return NotFound(pets.Errors);

            var petResponseDto = pets.Items.MapDto(breed);

            return Ok(petResponseDto);
        }

        [HttpGet("{id}/Medicine")]
        [Authorize(Policy = "AllUsers")]
        public async Task<IActionResult> GetMedicineFromPet(int id)
        {
            var pet = await _petService.GetByIdAsync(id);

            var userPetClaims = HttpContext.User.Claims;
            var userValidated = userPetClaims.CheckUserIdentity(pet.Item);

            if (!userValidated)
                return Forbid();

            if (!pet.IsSuccess)
                return BadRequest(pet.Errors);

            var medicine = await _petService.GetMedicineFromPetAsync(id);

            if (!medicine.IsSuccess)
                return BadRequest(medicine.Errors);

            var name = $"{pet.Item.Name}";

            var petResponseDto = medicine.Items.MapDto(name);

            return Ok(petResponseDto);
        }

        [HttpGet("{id}/Consultations")]
        [Authorize(Policy = "AllUsers")]
        public async Task<IActionResult> GetConsultationsFromPet(int id)
        {
            var pet = await _petService.GetByIdAsync(id);

            var userPetClaims = HttpContext.User.Claims;
            var userValidated = userPetClaims.CheckUserIdentity(pet.Item);

            if (!userValidated)
                return Forbid();

            if (!pet.IsSuccess)
                return BadRequest(pet.Errors);
           
            var consultations = await _petService.GetConsultationsFromPetAsync(id);

            if (!consultations.IsSuccess)
                return BadRequest(consultations.Errors);

            var name = $"{pet.Item.Name}";

            var petResponseDto = consultations.Items.MapDto(name);

            return Ok(petResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Create([FromForm] PetCreateDto petCreateDto)
        {
            var petModel = petCreateDto.MapModel();

            var result = await _petService.AddAsync(petModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Update([FromForm] PetUpdateDto petUpdateDto)
        {
            var petModel = petUpdateDto.MapModel();

            var result = await _petService.UpdateAsync(petModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
