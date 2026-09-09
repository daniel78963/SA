using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(150, ErrorMessage = "The field {0} must be at most {1} characters long")]
        public required string Title { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
