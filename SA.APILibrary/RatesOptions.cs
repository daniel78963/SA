using System.ComponentModel.DataAnnotations;

namespace SA.APILibrary
{
    public class RatesOptions
    {
        public const string Section = "rates";

        [Required]
        public int Day { get; set; }
        [Required]
        public int Night { get; set; }
    }
}
