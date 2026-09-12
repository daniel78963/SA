using Microsoft.AspNetCore.Mvc;
using SA.APILibrary.Entities;
using SA.APILibrary.Repositories;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly RepositoryValues repository;

        public ValuesController(RepositoryValues repository)
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
