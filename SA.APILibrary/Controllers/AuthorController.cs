using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Data;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AuthorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Author>> Get()
        {
            //return new List<Author>
            //{
            //    new Author { Id = 1, Name = "Author 1" },
            //    new Author { Id = 2, Name = "Author 2" }
            //};
            return await context.Authors.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Author>> Get(int Id)
        {
            var author = await context.Authors
                .Include(x => x.Books)
                .FirstOrDefaultAsync(x => x.Id == Id);
            if (author is null)
            {
                return NotFound();
            }
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
        public async Task<ActionResult> Post([FromBody] Author author)
        {
            // Logic to create a new author
            //return CreatedAtAction(nameof(GetAuthorById), new { id = author.Id }, author);
            context.Add(author);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Author author)
        {
            if (id != author.Id)
            {
                return BadRequest("Differents Ids");
            }
            //context.Update(author);
            //await context.SaveChangesAsync();
            //return Ok(author);

            // Logic to update an existing author
            var existingAuthor = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (existingAuthor is null)
            {
                return NotFound();
            }

            existingAuthor.Name = author.Name;
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
