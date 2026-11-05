using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary.DTOs
{
    public class EditClaimDTO
    {
        //[EmailAddress(ErrorMessage = "The email address is not valid.")]
        //[Required(ErrorMessage = "The email address is required.")]
        [EmailAddress]
        [Required]
        public required string Email { get; set; }
    }
}
