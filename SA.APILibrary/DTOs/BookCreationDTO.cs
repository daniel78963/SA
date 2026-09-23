using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.DTOs
{
    public class BookCreationDTO
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(250, ErrorMessage = "The field {0} must be at most {1} characters long")]
        public required string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
