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
    }
}
