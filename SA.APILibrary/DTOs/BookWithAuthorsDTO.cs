namespace SA.APILibrary.DTOs
{
    public class BookWithAuthorsDTO : BookDTO
    {
        //public int AuthorId { get; set; }
        //public required string AuthorName { get; set; }
        public List<AuthorDTO> Authors { get; set; } = [];
    }
}
