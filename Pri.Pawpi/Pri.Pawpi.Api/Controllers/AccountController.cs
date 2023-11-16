using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Pri.Pawpi.Api.DTOS.Account.Request;
using Pri.Pawpi.Api.DTOS.Account.Response;
using Pri.Pawpi.Core.Entities;
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
        private readonly IConfiguration _configuration;

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginRequestDto accountLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(accountLoginDto.Username, accountLoginDto.Password, false, false);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            var user = await _userManager.FindByNameAsync(accountLoginDto.Username);
            var claims = await _userManager.GetClaimsAsync(user);
            claims.Add(new Claim(ClaimTypes.PrimarySid, user.Id));

            // put roles in claims
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

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
    }
}
