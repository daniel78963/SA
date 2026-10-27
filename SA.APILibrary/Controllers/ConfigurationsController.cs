using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/configurations")]
    public class ConfigurationsController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IConfigurationSection section_01;
        private readonly IConfigurationSection section_02;
        private readonly PersonOptions _personOptions;

        public ConfigurationsController(IConfiguration configuration, IOptions<PersonOptions> personOptions)
        //public ConfigurationsController(IConfiguration configuration, IOptionsSnapshot<PersonOptions> personOptions)
        {
            //IOptionsSnapshot: carga la configuración cada vez que se hace una petición, por lo que si se cambia la configuración en el archivo appsettings.json, se reflejará en la siguiente petición. Esto es útil para aplicaciones que necesitan cambiar la configuración en tiempo de ejecución, como por ejemplo una aplicación que permite cambiar el tema de la interfaz de usuario sin reiniciar la aplicación. Sin embargo, esto puede tener un impacto en el rendimiento si se hace muchas peticiones, ya que cada petición cargará la configuración desde el archivo appsettings.json. Por lo tanto, se debe usar con precaución y solo cuando sea necesario.
            this.configuration = configuration;
            _personOptions = personOptions.Value;
            section_01 = configuration.GetSection("section_1");
            section_02 = configuration.GetSection("section_2");
        }

        [HttpGet("personOptions_section1")]
        public ActionResult<PersonOptions> GetPersonOptionsSection1()
        {
            //_personOptions.Name;
            return Ok(_personOptions);
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

        [HttpGet("configurations")]
        public ActionResult<string> GetTest()
        {
            var value = configuration["test_dicConfigurations"];
            var valueSecret = configuration["how_i_am_secret"];
            return Ok($"Value: {value}, Secret: {valueSecret}");
        }
    }
}
