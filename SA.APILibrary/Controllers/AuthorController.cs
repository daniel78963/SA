using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Data;
using SA.APILibrary.DTOs;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<AuthorController> logger;
        private readonly IMapper mapper;

        public AuthorController(ApplicationDbContext context, IMapper mapper, ILogger<AuthorController> logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<AuthorDTO>> Get()
        {
            //logger.LogTrace("Getting all authors");
            //logger.LogDebug("Getting all authors");
            //logger.LogInformation("Getting all authors");
            //logger.LogWarning("Getting all authors");
            //logger.LogError("Getting all authors");
            //logger.LogCritical("Getting all authors");

            //return new List<Author>
            //{
            //    new Author { Id = 1, Name = "Author 1" },
            //    new Author { Id = 2, Name = "Author 2" }
            //};

            //return await context.Authors.ToListAsync();
            var authors = await context.Authors.ToListAsync();
            //var authorsDto = authors.Select(a => new AuthorDTO
            //{
            //    Id = a.Id,
            //    FullName = $"{a.Names} {a.Surnames}"
            //});
            var authorsDto = mapper.Map<IEnumerable<AuthorDTO>>(authors);
            return authorsDto;
        }

        [HttpGet("{id:int}", Name = "GetAuthor")]
        public async Task<ActionResult<AuthorDTO>> Get(int Id)
        {
            var author = await context.Authors
                .Include(x => x.Books)
                .FirstOrDefaultAsync(x => x.Id == Id);
            if (author is null)
            {
                return NotFound();
            }

            var authorDto = mapper.Map<AuthorDTO>(author);
            return Ok(author);
        }

        [HttpGet("api/authors")]
        public IActionResult GetAuthors()
        {
            // Logic to retrieve authors from the database or any data source
            var authors = new List<string> { "Author 1", "Author 2", "Author 3" };
            return Ok(authors);
        }

        [HttpGet("api/authors/{id}")]
        public IActionResult GetAuthorById(int id)
        {
            // Logic to retrieve a specific author by ID
            var author = $"Author {id}";
            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AuthorCreationDTO authorCreationDto)
        {
            // Logic to create a new author
            var author = mapper.Map<Author>(authorCreationDto);
            context.Add(author);
            //context.Authors.Add(author);
            await context.SaveChangesAsync();
            //return Ok();
            var authorDto = mapper.Map<AuthorDTO>(author);
            return new CreatedAtRouteResult("GetAuthor", new { id = author.Id }, authorDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] AuthorCreationDTO authorCreationDto)
        {
            // Logic to update an existing author
            //if (id != author.Id)
            //{
            //    return BadRequest("Differents Ids");
            //}

            //context.Update(author);
            //await context.SaveChangesAsync();
            //return Ok(author);
            var author = mapper.Map<Author>(authorCreationDto);
            author.Id = id; // Set the ID of the author to the provided ID
            var existingAuthor = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (existingAuthor is null)
            {
                return NotFound();
            }

            existingAuthor.Names = author.Names;
            // Update other properties as needed

            //context.Update(existingAuthor);
            await context.SaveChangesAsync();
            return Ok(existingAuthor);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Logic to delete an author
            var existingAuthor = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (existingAuthor is null)
            {
                return NotFound();
            }
            context.Remove(existingAuthor);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}
