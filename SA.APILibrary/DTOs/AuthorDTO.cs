namespace SA.APILibrary.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public List<BookDTO> Books { get; set; } = [];
    }
}
