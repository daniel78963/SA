using Microsoft.AspNetCore.Mvc;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/configurations")]
    public class ConfigurationsController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IConfigurationSection section_01;
        private readonly IConfigurationSection section_02;

        public ConfigurationsController(IConfiguration configuration)
        {
            this.configuration = configuration;
            section_01 = configuration.GetSection("section_1");
            section_02 = configuration.GetSection("section_2");
        }

        [HttpGet("section_01")]
        public ActionResult<string> GetSection_01()
        {
            var name = section_01.GetValue<string>("name");
            var age = section_01.GetValue<int>("age");
            return Ok($"Name: {name}, Age: {age}");
        }

        [HttpGet("section_02")]
        public ActionResult<string> GetSection_02()
        {
            var name = section_02.GetValue<string>("name");
            var age = section_02.GetValue<int>("age");
            return Ok($"Name: {name}, Age: {age}");
        }

        [HttpGet("GetAllSections")]
        public ActionResult<string> GetAllSections()
        {
            var childs = section_02.GetChildren().Select(x => $"{x.Key}: {x.Value}");
            return Ok(new { childs });
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
