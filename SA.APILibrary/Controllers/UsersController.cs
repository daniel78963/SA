using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SA.APILibrary.DTOs;
using SA.APILibrary.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/users")]
    //[Authorize]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IUserServices userServices;

        public UsersController(UserManager<IdentityUser> userManager, IConfiguration configuration
            , SignInManager<IdentityUser> signInManager, IUserServices userServices)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signInManager;
            this.userServices = userServices;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<AnswerAuthenticationDTO>> Login([FromBody] UserCredentialsDTO credentials)
        {
            var user = await userManager.FindByEmailAsync(credentials.Email!);
            if (user == null)
            {
                return ReturnLoginIncorrect();
            }

            var result = await signInManager.CheckPasswordSignInAsync(user, credentials.Password!, lockoutOnFailure: false); // lockoutOnFailure: false: no bloquear al usuario después de varios intentos fallidos

            if (result.Succeeded)
            {
                return await BuildToken(credentials);
            }
            else
            {
                return ReturnLoginIncorrect();
            }

            //var isPasswordValid = await userManager.CheckPasswordAsync(user, credentials.Password!);
            //if (!isPasswordValid)
            //{
            //    return ReturnLoginIncorrect();
            //}

            //var answer = await BuildToken(credentials);
            //return answer;
        }

        private ActionResult ReturnLoginIncorrect()
        {
            ModelState.AddModelError(string.Empty, "Login incorrect");
            return ValidationProblem();
        }

        [HttpPost("register")]
        [AllowAnonymous]
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
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddMinutes(10000);
            var token = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiration, signingCredentials: creds);
            return new AnswerAuthenticationDTO()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

        [HttpGet("refresh-token")]
        [Authorize]
        public async Task<ActionResult<AnswerAuthenticationDTO>> RefreshToken()
        {
            var user = await userServices.GetCurrentUserAsync();
            if (user is null)
            {
                return Unauthorized();
            }
            var credentials = new UserCredentialsDTO()
            {
                Email = user.Email!
            };
            var answerAuth = await BuildToken(credentials);
            return answerAuth;
        }

        [HttpPost("do-admin")]
        [Authorize(Policy = "isadmin")] // esto se comenta mientras se hace al menos a un usuario como admin
        public async Task<ActionResult> DoAdmin([FromBody] EditClaimDTO dto)
        {
            var user = await userManager.FindByEmailAsync(dto.Email!);
            if (user is null)
            {
                return NotFound();
            }
            //var result = await userManager.AddToRoleAsync(user, "Admin");
            //if (result.Succeeded)
            //{
            //    return Ok();
            //}
            //else
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError(string.Empty, error.Description);
            //    }
            //    return ValidationProblem();
            //}

            await userManager.AddClaimAsync(user, new Claim("isadmin", "true"));
            return NoContent();
        }

        [HttpPost("remove-admin")]
        [Authorize(Policy = "isadmin")]
        public async Task<ActionResult> RemoveAdmin([FromBody] EditClaimDTO dto)
        {
            var user = await userManager.FindByEmailAsync(dto.Email!);
            if (user is null)
            {
                return NotFound();
            } 
            await userManager.RemoveClaimAsync(user, new Claim("isadmin", "true"));
            return NoContent();
        }
    }
}
