using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace SA.APILibrary.Controllers
{
    [Route("api/security")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly IDataProtector protector;
        private readonly ITimeLimitedDataProtector protectorLimitedTime;

        public SecurityController(IDataProtectionProvider protectionProvider)
        {
            protector = protectionProvider.CreateProtector("SA.APILibrary.SecurityController"); // Esto no es la llave, es parte de la llave
            protectorLimitedTime = protector.ToTimeLimitedDataProtector();
        }

        [HttpGet("protect")]
        public IActionResult ProtectData([FromQuery] string data)
        {
            var protectedData = protector.Protect(data);
            return Ok(new { protectedData });
        }

        [HttpGet("unprotect")]
        public IActionResult UnprotectData([FromQuery] string protectedData)
        {
            var data = protector.Unprotect(protectedData);
            return Ok(new { data });
        }

        [HttpGet("protect-time")]
        public IActionResult ProtectDataTime([FromQuery] string data)
        {
            var protectedData = protectorLimitedTime.Protect(data, lifetime: TimeSpan.FromSeconds(30));
            return Ok(new { protectedData });
        }

        [HttpGet("unprotect-time")]
        public IActionResult UnprotectDataTime([FromQuery] string protectedData)
        {
            var data = protectorLimitedTime.Unprotect(protectedData);
            return Ok(new { data });
        }
    }
}
