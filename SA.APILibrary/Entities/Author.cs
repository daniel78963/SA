using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        [Range(1, 150, ErrorMessage = "The field {0} must be between {1} and {2}")]
        public int Age { get; set; }

        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public string? CreditCardNumber { get; set; }

        [Url]
        public string? URL { get; set; }

    }
}
