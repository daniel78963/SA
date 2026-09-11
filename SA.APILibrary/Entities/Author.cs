using SA.APILibrary.Validations;
using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.Entities
{
    public class Author : IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "The field {0} must be at most {1} characters long")]
        [FirstLetterMayus]
        public required string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        [Range(1, 150, ErrorMessage = "The field {0} must be between {1} and {2}")]
        public int Age { get; set; }

        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public string? CreditCardNumber { get; set; }

        [Url]
        public string? URL { get; set; }

        /// <summary>
        /// Las validaciones por modelo son utiles para combinar campos o que requieren una lógica más compleja.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                var firstLetter = Name[0].ToString();

                if (firstLetter != firstLetter.ToUpper())
                //if (firstLetter != firstLetter.ToUpper() && Age > 40)
                {
                    yield return new ValidationResult("The first letter must be uppercase - by model", new[] { nameof(Name) });
                }
            }
        }
    }
}
