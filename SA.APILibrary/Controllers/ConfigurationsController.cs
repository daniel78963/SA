using Microsoft.AspNetCore.Mvc;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/configurations")]
    public class ConfigurationsController : Controller
    {
        private readonly IConfiguration configuration;

        public ConfigurationsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public ActionResult<string> GetConfigurations()
        {
            var option0 = configuration.GetValue<string>("lastName");
            var option1 = configuration["lastName"];

            //var option2 = configuration.GetSection("Logging:LogLevel:Default").Value;
            //var option3 = configuration.GetValue<string>("Logging:LogLevel:Default");
            return Ok(option0);
        }

        [HttpGet("sections")]
        public ActionResult<string> GetSections(string key)
        {
            var value = configuration["ConnectionStrings:DefaultConnection"];
            var value2 = configuration.GetConnectionString("DefaultConnection");
            var value3 = configuration.GetSection("ConnectionStrings")["DefaultConnection"];
            var section = configuration.GetSection("ConnectionStrings");
            var value4 = section.GetValue<string>("DefaultConnection");
            return Ok(value);
        }
    }
}
