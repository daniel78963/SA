using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
    }
}
