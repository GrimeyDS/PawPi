using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        protected readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetAllAsync();

            var customerResponseDto = customers.Items.MapCustomersDto();

            return Ok(customerResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customers = await _customerService.GetByIdAsync(id);

            if (!customers.IsSuccess)
                return BadRequest(customers.Errors);

            var customerResponseDto = customers.Item.MapCustomerDto();

            return Ok(customerResponseDto);
        }
    }
}
