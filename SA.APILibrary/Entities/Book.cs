using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
