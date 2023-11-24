using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;
using System.Security.Claims;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController<Customer>
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetAllAsync();
            var customerResponseDto = customers.Items.MapDto();

            return Ok(customerResponseDto);
        }

        [HttpGet("{id:int}")]
        [Authorize(Policy = "AllUsers")]
        public async Task<IActionResult> Get(int id)
        {
            var userCustomerClaims = HttpContext.User.Claims;
            var userValidated = userCustomerClaims.CheckUserIdentity(id);

            if (!userValidated)
                return Unauthorized();

            var customer = await _customerService.GetByIdAsync(id);

            if (!customer.IsSuccess)
                return BadRequest(customer.Errors);

            var customerResponseDto = customer.Item.MapDto();

            return Ok(customerResponseDto);
        }

        [HttpGet("searchName/{name}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var customers = await _customerService.SearchByNameAsync(name);

            if (!customers.IsSuccess)
                return NotFound(customers.Errors);

            var customerResponseDto = customers.Items.MapDto(name);

            return Ok(customerResponseDto);
        }

        [HttpGet("searchAddress/{address}")]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> SearchByAddress(string address)
        {
            var customers = await _customerService.SearchByAddressAsync(address);

            if (!customers.IsSuccess)
                return NotFound(customers.Errors);

            var customerResponseDto = customers.Items.MapDto(address);

            return Ok(customerResponseDto);
        }

        [HttpGet("{id}/Pets")]
        [Authorize(Policy = "AllUsers")]
        public async Task<IActionResult> GetPetsByCustomer(int id)
        {
            var userCustomerClaims = HttpContext.User.Claims;
            var userValidated = userCustomerClaims.CheckUserIdentity(id);

            if (!userValidated)
                return Unauthorized();

            var pets = await _customerService.GetPetsFromCustomerAsync(id);
            var customer = await _customerService.GetByIdAsync(id);

            if (!pets.IsSuccess)
                return BadRequest(pets.Errors);

            var name = $"{customer.Item.FirstName} {customer.Item.LastName}";

            var customerResponseDto = pets.Items.MapDto(name);

            return Ok(customerResponseDto);
        }

        [HttpPost]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Create(CustomerCreateDto customerCreateDto)
        {
            var customerModel = customerCreateDto.MapModel();

            var result = await _customerService.AddAsync(customerModel);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok("Added");
        }

        [HttpPut]
        [Authorize(Policy = "Practice/Veterinarian")]
        public async Task<IActionResult> Update(CustomerUpdateDto customerUpdateDto)
        {
            var customerModel = customerUpdateDto.MapModel();

            var result = await _customerService.UpdateAsync(customerModel);

            if (!result.IsSuccess)
                return NotFound(result.Errors);

            return Ok("Updated");
        }
    }
}
