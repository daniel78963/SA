using Microsoft.AspNetCore.Mvc;
using SA.APILibrary.Entities;
using SA.APILibrary.Interfaces;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IRepositoryValues repository;
        private readonly TransientService transient1;
        private readonly TransientService transient2;
        private readonly SingletonService singleton1;
        private readonly ScopedService scoped1;
        private readonly ScopedService scoped2;

        //public ValuesController(IRepositoryValues repository)
        //{
        //    this.repository = repository;
        //}
        public ValuesController(IRepositoryValues repository,
            TransientService transient1,
            TransientService transient2,
            SingletonService singleton1,
            ScopedService scoped1,
            ScopedService scoped2)
        {
            this.repository = repository;
            this.transient1 = transient1;
            this.transient2 = transient2;
            this.singleton1 = singleton1;
            this.scoped1 = scoped1;
            this.scoped2 = scoped2;
        }

        [HttpGet]
        public IEnumerable<Values> Get()
        {
            return repository.GetValues();
        }

        [HttpGet("Services")]
        public IActionResult GetServices()
        {
            return Ok(new
            {
                Transients = new
                {
                    transient1 = transient1.GetGuid,
                    transient2 = transient2.GetGuid
                },
                Scopeds = new
                {
                    scoped1 = scoped1.GetGuid,
                    scoped2 = scoped2.GetGuid
                },
                Singleton = new
                {
                    singleton1 = singleton1.GetGuid
                }
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Values value)
        {
            repository.AddValue(value);
            return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
        }
    }
}
