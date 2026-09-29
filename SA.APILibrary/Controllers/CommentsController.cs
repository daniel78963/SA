using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Data;
using SA.APILibrary.DTOs;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/books/{bookId:int}/comments")]
    public class CommentsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CommentsController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return Ok("Comments");
        //}

        [HttpGet]
        public async Task<ActionResult<List<CommentDTO>>> Get(int bookId)
        {
            var book = await context.Books.AnyAsync(b => b.Id == bookId);

            if (!book)
            {
                return NotFound();
            }

            var comments = await context.Comments
                .Where(c => c.BookId == bookId)
                .OrderByDescending(c => c.PublishDate)
                .ToListAsync();

            return Ok(mapper.Map<List<CommentDTO>>(comments));
        }

        [HttpGet("{commentId}", Name = "GetComment")]
        public async Task<ActionResult<CommentDTO>> GetComment(Guid commentId)
        {
            var comment = await context.Comments.FirstOrDefaultAsync(c => c.Id == commentId);

            if (comment is null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<CommentDTO>(comment));
        }

        [HttpPost]
        public async Task<ActionResult> Post(int bookId, CommentCreationDTO commentCreationDTO)
        {
            var book = await context.Books.AnyAsync(b => b.Id == bookId);
            if (!book)
            {
                return NotFound();
            }
            var comment = mapper.Map<Entities.Comment>(commentCreationDTO);
            comment.BookId = bookId;
            comment.PublishDate = DateTime.UtcNow;
            context.Add(comment);
            await context.SaveChangesAsync();
            var commentDTO = mapper.Map<CommentDTO>(comment);
            return CreatedAtRoute("GetComment", new { Id = comment.Id, bookId }, commentDTO);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> Patch(Guid id, int bookId, JsonPatchDocument<CommentPatchDTO> patchDoc)
        {
            if (patchDoc is null)
            {
                return BadRequest();
            }

            // Logic to partially update an existing author
            var commentDB = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            if (commentDB is null)
            {
                return NotFound();
            }

            var commentPatchDTO = mapper.Map<CommentPatchDTO>(commentDB);
            patchDoc.ApplyTo(commentPatchDTO, ModelState);
            var isValid = TryValidateModel(commentPatchDTO);
            if (!isValid)
            {
                return ValidationProblem();
            }

            mapper.Map(commentPatchDTO, commentDB);
            await context.SaveChangesAsync();
            return NoContent(); //204 todo ok pero no devuelve nada (objeto)
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id, int bookId)
        {
            var commentDB = await context.Comments.AnyAsync(c => c.Id == id);
            if (!commentDB)
            {
                return NotFound();
            }
            //context.Remove(commentDB);
            var recordsDeleted = await context.Comments.Where(c => c.Id == id).ExecuteDeleteAsync();
            
            await context.SaveChangesAsync();
            if (recordsDeleted == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
