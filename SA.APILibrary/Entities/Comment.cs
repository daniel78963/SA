using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        [Required]
        public required string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public int BookId { get; set; }
        //Propiedad de navegación para la relación con la entidad Book
        public Book? Book { get; set; }
    }
}
