namespace SA.APILibrary.DTOs
{
    public class AnswerAuthenticationDTO
    {
        public required string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
