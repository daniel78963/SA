using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Data;
using SA.APILibrary.DTOs;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/authors-collection")]
    public class AuthorsCollectionController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AuthorsCollectionController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{ids}", Name = "GetAuthorsCollection")] // api/authors-collection/1,2,3
                                                          //public async Task<ActionResult<IEnumerable<AuthorDTO>>> Get([FromQuery] IEnumerable<int> ids)
        public async Task<ActionResult<IEnumerable<AuthorWithBooksDTO>>> Get(string ids)
        { 
            //var idCollection = ids.Split(',').Select(int.Parse);
            var idsCollection = ids.Split(',').Select(id => int.TryParse(id, out var parsedId) ? parsedId : (int?)null);
            if (!idsCollection.Any())
            {
                ModelState.AddModelError(nameof(ids), "No ID was found.");
                return ValidationProblem();
            }

            var authors = await context.Authors
                .Include(x=> x.Books)
                .ThenInclude(ab => ab.Book)
                .Where(a => idsCollection.Contains(a.Id)).ToListAsync();

            if (authors.Count != idsCollection.Count())
            {
                return NotFound();
            }
            var authorsDTO = mapper.Map<IEnumerable<AuthorDTO>>(authors);
            return Ok(authorsDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] IEnumerable<AuthorCreationDTO> authorCreationDTOs)
        {
            var authors = mapper.Map<IEnumerable<Author>>(authorCreationDTOs);
            context.AddRange(authors);
            await context.SaveChangesAsync();
            var authorsDTO = mapper.Map<IEnumerable<AuthorDTO>>(authors);
            var ids = string.Join(",", authors.Select(x => x.Id));
            return CreatedAtRoute("GetAuthorsCollection", new { ids }, authorsDTO);
        }
    }
}
