using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.DTOs
{
    public class CommentDTO
    {
        public Guid Id { get; set; } 
        public required string Body { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
