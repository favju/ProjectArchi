namespace WebApi.Models
{
    public class UserM
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public int CardId { get; set; }
        public CardM Card { get; set; }
    }
}
