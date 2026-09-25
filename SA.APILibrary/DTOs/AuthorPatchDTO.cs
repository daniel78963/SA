using SA.APILibrary.Validations;
using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.DTOs
{
    public class AuthorPatchDTO
    {
        [Required]
        [StringLength(150, ErrorMessage = "The field {0} must be at most {1} characters long")]
        [FirstLetterMayus]
        public required string Names { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "The field {0} must be at most {1} characters long")]
        [FirstLetterMayus]
        public required string Surnames { get; set; }

        [StringLength(20, ErrorMessage = "The field {0} must be at most {1} characters long")]
        public required string Document { get; set; }
    }
}
