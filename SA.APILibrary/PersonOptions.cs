using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary
{
    public class PersonOptions
    {
        public const string Section = "section_1";

        [Required]
        public required string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
