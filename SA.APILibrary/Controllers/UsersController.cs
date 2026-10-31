using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SA.APILibrary.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;

        public UsersController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AnswerAuthenticationDTO>> Register([FromBody] UserCredentialsDTO credentials)
        {
            // Implementation for user registration
            var user = new IdentityUser { UserName = credentials.Email, Email = credentials.Email };
            var result = await userManager.CreateAsync(user, credentials.Password!);

            if (result.Succeeded)
            {
                var answer = await BuildToken(credentials);
                return answer;
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return ValidationProblem();
            }
        }

        private async Task<AnswerAuthenticationDTO> BuildToken(UserCredentialsDTO credentials)
        {
            var claims = new List<Claim>()
            {
                new Claim("email", credentials.Email!),
                new Claim("lo que yo quiera", "cualquier valor")
            };
            var user = await userManager.FindByEmailAsync(credentials.Email!);
            var claimsDB = await userManager.GetClaimsAsync(user!);
            claims.AddRange(claimsDB);
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration["jwtkey"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddMinutes(10);
            var token = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiration, signingCredentials: creds);
            return new AnswerAuthenticationDTO()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}
