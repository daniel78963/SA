using Microsoft.AspNetCore.Identity;

namespace SA.APILibrary.Entities
{
    public class User : IdentityUser
    {
        public DateTime? DateBirth { get; set; }
        //public string? LastName { get; set; }
        //public string? PhoneNumber { get; set; }
        //public string? Address { get; set; }
        //public string? City { get; set; }
        //public string? State { get; set; }
        //public string? Country { get; set; }
        //public string? PostalCode { get; set; }
    }
}
