namespace WebApi.Models
{
    public class CardM
    {
        public int Id { get; set; }
        public float Quota { get; set; }
        public int UserId { get; set; }
        public UserM User { get; set; }
    }
}
