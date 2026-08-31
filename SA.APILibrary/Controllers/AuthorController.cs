using Microsoft.AspNetCore.Mvc;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
             return "authors";
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
