using Microsoft.AspNetCore.Mvc;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return new List<Author> 
            {
                new Author { Id = 1, Name = "Author 1" },
                new Author { Id = 2, Name = "Author 2" }
            };
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
    }
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}
