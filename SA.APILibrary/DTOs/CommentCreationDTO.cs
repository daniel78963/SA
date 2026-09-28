using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.DTOs
{
    public class CommentCreationDTO
    {
        [Required]
        public required string Body { get; set; }
    }
}
