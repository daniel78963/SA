using Microsoft.AspNetCore.Mvc;
using SA.APILibrary.Entities;
using SA.APILibrary.Interfaces;
using SA.APILibrary.Repositories;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IRepositoryValues repository;

        public ValuesController(IRepositoryValues repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Values> Get()
        {
            return repository.GetValues();
        }
    }
}
