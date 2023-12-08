using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
using Pri.Pawpi.Api.DTOS.Account.Request;
using Pri.Pawpi.Api.DTOS.Account.Response;
using Pri.Pawpi.Api.Extensions;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Pri.Pawpi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICustomerService _customerService;
        private readonly IVeterinarianService _veterinarianService;
        private readonly IConfiguration _configuration;

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IConfiguration configuration, ICustomerService customerService, IVeterinarianService veterinarianService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
            _customerService = customerService;
            _veterinarianService = veterinarianService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(AccountLoginRequestDto accountLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(accountLoginDto.Username, accountLoginDto.Password, false, false);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            var user = await _userManager.FindByNameAsync(accountLoginDto.Username);
            var claims = await _userManager.GetClaimsAsync(user);

            var securityKey =
                new SymmetricSecurityKey
                (Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigninKey")));

            var token = new JwtSecurityToken
                (
                    audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                    issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                    claims: claims,
                    expires: DateTime.Now.AddDays(_configuration.GetValue<int>("JWTConfiguration:TokenExpiration")),
                    signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
                );

            var serializedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(new AccountLoginResponseDto { Token = serializedToken });
        }

        [HttpPost("RegisterCustomer")]
        public async Task<IActionResult> Register(CustomerRegisterRequestDto accountRegisterDto)
        {
            var user = new ApplicationUser
            {
                UserName = accountRegisterDto.Email,
                Email = accountRegisterDto.Email,
                EmailConfirmed = true
            };

            var customerModel = accountRegisterDto.MapModel();

            var customerResult = await _customerService.AddAsync(customerModel);

            if (!customerResult.IsSuccess)
                return BadRequest(customerResult.Errors);

            user.CustomerId = customerResult.Item.Id;

            var result = await _userManager.CreateAsync(user, accountRegisterDto.Password);

            if (!result.Succeeded)
            {
                await _customerService.DeleteAsync(customerResult.Item.Id);
                return BadRequest(result.Errors);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, "Customer"),
                new Claim(ClaimTypes.PrimarySid, user.Id)
            };

            result = await _userManager.AddClaimsAsync(user, claims);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("Customer registered");
        }

        [Authorize(Policy = "Practice")]
        [HttpPost("RegisterVeterinarian")]
        public async Task<IActionResult> Register([FromForm] VeterinarianRegisterRequestDto accountRegisterDto)
        {
            var user = new ApplicationUser
            {
                UserName = accountRegisterDto.Email,
                Email = accountRegisterDto.Email,
                EmailConfirmed = true
            };

            var vetModel = accountRegisterDto.MapModel();

            var vetResult = await _veterinarianService.AddAsync(vetModel);

            if (!vetResult.IsSuccess)
                return BadRequest(vetResult.Errors);

            user.VeterinarianId = vetResult.Item.Id;

            var result = await _userManager.CreateAsync(user, accountRegisterDto.Password);

            if (!result.Succeeded)
            {
                await _veterinarianService.DeleteAsync(vetResult.Item.Id);
                return BadRequest(result.Errors);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, "Veterinarian"),
                new Claim(ClaimTypes.PrimarySid, user.Id)
            };

            result = await _userManager.AddClaimsAsync(user, claims);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("Veterinarian registered");
        }

        [Authorize(Policy = "AllUsers")]
        [HttpGet("GetRole")]
        public IActionResult GetRole()
        {
            var userClaims = HttpContext.User.Claims;
            var role = userClaims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role));
            var roleArray = role.ToString().Split("role: ");
            var roleString = roleArray[1];

            return Ok(roleString);
        }

        [Authorize(Policy = "AllUsers")]
        [HttpGet("GetId")]
        public IActionResult GetId()
        {
            var userClaims = HttpContext.User.Claims;
            var id = userClaims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.PrimarySid));
            var idArray = id.ToString().Split("primarysid: ");
            var idString = idArray[1];

            return Ok(idString);
        }
    }
}
