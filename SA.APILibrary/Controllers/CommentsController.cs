using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Data;
using SA.APILibrary.DTOs;
using SA.APILibrary.Entities;
using SA.APILibrary.Services;

namespace SA.APILibrary.Controllers
{
    [ApiController]
    [Route("api/books/{bookId:int}/comments")]
    [Authorize]
    public class CommentsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IUserServices userServices;

        public CommentsController(ApplicationDbContext context, IMapper mapper, IUserServices userServices)
        {
            this.context = context;
            this.mapper = mapper;
            this.userServices = userServices;
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
                .Include(c => c.User)
                .Where(c => c.BookId == bookId)
                .OrderByDescending(c => c.PublishDate)
                .ToListAsync();

            return Ok(mapper.Map<List<CommentDTO>>(comments));
        }

        [HttpGet("{id}", Name = "GetComment")]
        public async Task<ActionResult<CommentDTO>> GetComment(Guid commentId)
        {
            var comment = await context.Comments
                .Include(c => c.User)
                .FirstOrDefaultAsync(c => c.Id == commentId);

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

            var user = await userServices.GetCurrentUserAsync();
            if (user is null)
            {
                return Unauthorized();
            }

            var comment = mapper.Map<Entities.Comment>(commentCreationDTO);
            comment.BookId = bookId;
            comment.PublishDate = DateTime.UtcNow;
            comment.UserId = user.Id;
            context.Add(comment);
            await context.SaveChangesAsync();
            var commentDTO = mapper.Map<CommentDTO>(comment);
            return CreatedAtRoute("GetComment", new { id = comment.Id, bookId }, commentDTO);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> Patch(Guid id, int bookId, JsonPatchDocument<CommentPatchDTO> patchDoc)
        {
            if (patchDoc is null)
            {
                return BadRequest();
            }

            var book = await context.Books.AnyAsync(b => b.Id == bookId);
            if (!book)
            {
                return NotFound();
            }

            var user = await userServices.GetCurrentUserAsync();
            if (user is null)
            {
                return Unauthorized();
            }

            var commentDB = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            if (commentDB is null)
            {
                return NotFound();
            }

            if (commentDB.UserId != user.Id)
            {
                return Forbid(); //403 Forbidden, el usuario autenticado no es el propietario del comentario
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
            var book = await context.Books.AnyAsync(b => b.Id == bookId);
            if (!book)
            {
                return NotFound();
            }

            var user = await userServices.GetCurrentUserAsync();
            if (user is null)
            {
                return Unauthorized();
            }

            //var commentDB = await context.Comments.AnyAsync(c => c.Id == id);
            //if (!commentDB)
            //{
            //    return NotFound();
            //}
            ////context.Remove(commentDB);
            //var recordsDeleted = await context.Comments.Where(c => c.Id == id).ExecuteDeleteAsync();

            //await context.SaveChangesAsync();
            //if (recordsDeleted == 0)
            //{
            //    return NotFound();
            //}
            var commentDb  = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            if (commentDb  is null)
            {
                return NotFound();
            }

            if (commentDb.UserId != user.Id)
            {
                return Forbid(); //403 Forbidden, el usuario autenticado no es el propietario del comentario
            }
            context.Remove(commentDb);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
