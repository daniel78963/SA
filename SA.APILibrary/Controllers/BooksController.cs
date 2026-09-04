using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Data;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context            )
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books
                .Include(x => x.Author)
                .ToListAsync(); 
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var book = await _context.Books
                .Include(x => x.Author)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Book book)
        {
            var existingAuthor = await _context.Authors.AnyAsync(x => x.Id == book.AuthorId);
            
            if (!existingAuthor)
            {
                return BadRequest("Invalid AuthorId");
            }

            _context.Add(book);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest("Differents Ids");
            }

            var existingAuthor = await _context.Authors.AnyAsync(x => x.Id == book.AuthorId);

            if (!existingAuthor)
            {
                return BadRequest("Invalid AuthorId");
            }

            var existingBook = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (existingBook is null)
            {
                return NotFound();
            }
            _context.Entry(existingBook).CurrentValues.SetValues(book);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            //var booksDeleted = await _context.Books.Where(x => x.Id == id).ExecuteDeleteAsync();
            //if (booksDeleted == 0)
            //{
            //    return NotFound();
            //}

            var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
          
            if (book is null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
